using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MP3Player
{
    public partial class Form1 : Form
    {
        // System Variables.
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        // Application Variables.
        bool isPaused = true;
        bool isMuted = false;
        int PlayerVolume = 3;
        string TreeSelected = "";
        string PlayingSongTitle = "PlayerSongNameTitle";
        int selectedItemEnum;

        // Directory location.
        DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\Jared\Documents\Music");

        // Import volume control.
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
           IntPtr wParam, IntPtr lParam);




        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            // If music location exists load into Treeview1.
            if (directoryInfo.Exists)
            {
                try
                {
                    treeView1.Nodes.Add(LoadDirectory(directoryInfo));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            
            
        }       

        // Add nodes to Treeview from location defined in DirectoryLocation.
        private TreeNode LoadDirectory(DirectoryInfo di)
        {
            if (!di.Exists)
                return null;

            TreeNode output = new TreeNode(di.Name, 0, 0);

            foreach (var subDir in di.GetDirectories())
            {
                try
                {
                    output.Nodes.Add(LoadDirectory(subDir));
                }
                catch (IOException ex)
                {
                    //handle error
                }
                catch { }
            }

            foreach (var file in di.GetFiles())
            {
                if (file.Exists)
                {
                    output.Nodes.Add(file.Name);
                }
            }

            return output;
        }

        // Retrieve song information from listBox2.
        private void UpdateSongInfo()
        {
            selectedItemEnum = listBox2.SelectedIndex;
            PlayerSongNameTitle.Text = listBox2.Items[selectedItemEnum].ToString();
            PlayerAlbumNameTitle.Text = "Album Name Here";
            PlayerArtistNameTitle.Text = "Artist Name Here";
            PlayerSongLengthTitle.Text = "Song Length Here";
        }


        // Play/Pause button functionality.
        private void PlayerButtonPause_Click(object sender, EventArgs e)
        {
            // Button text.
            if (isPaused == true)
            {
                PlayerButtonPause.Text = "Play";
                isPaused = false;
            }
            else
            {
                PlayerButtonPause.Text = "Pause";
                isPaused = true;
            }

            // Change song information.
            if (listBox2.Items.Count > 0)
            {
                UpdateSongInfo();
                pictureBox1.Image = Image.FromFile(@"C:\Users\Jared\Documents\GitHub\MP3Player\MP3Player\mp3thumb.png");
            }
            else
            {
                MessageBox.Show("Playlist cannot be empty.");
            } //TODO: album, artist, length metadata.



        }
        // Mute/Unmute functionality. 
        private void PlayerButtonMute_Click(object sender, EventArgs e)
        {
            //TODO add check to determine if "play" or "mute" should be displayed.
            if (isMuted == true)
            {
                PlayerButtonMute.Text = "UnMute";
                isMuted = false;

            }
            else
            {
                PlayerButtonMute.Text = "Mute";
                isMuted = true;
            }

            //  SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
            //     (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        // Volume down.
        private void PlayerButtonDown_Click(object sender, EventArgs e)
        {
            if (PlayerVolume >= 1)
                PlayerVolume = PlayerVolume - 1;
            PlayerVolumeLabel.Text = " " + PlayerVolume;

            //  SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
            //      (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        // Volume up.
        private void PlayerButtonUp_Click(object sender, EventArgs e)
        {
            if (PlayerVolume <= 9)
                PlayerVolume = PlayerVolume + 1;
            PlayerVolumeLabel.Text = " " + PlayerVolume;

            //  SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
            //      (IntPtr)APPCOMMAND_VOLUME_UP);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //TODO: transfer functionality from label to container.
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeSelected = e.Node.Text;
           //DEBUG MessageBox.Show(TreeSelected);
        }

        // On button click move selected tree item to list.
        private void ButtonMoveToList_Click(object sender, EventArgs e)
        {
            if (TreeSelected != "")
            {
                listBox2.Items.Add(TreeSelected);
                TreeSelected = "";
                listBox2.SelectedIndex = 0;
            }
            else
            {
                // Throw error if no item selected.
                MessageBox.Show("You must select an item.");
            }
        }

        // On clear button click clear listbox reset selected item.
        private void LibraryButtonClear_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            TreeSelected = "";

            selectedItemEnum = listBox2.SelectedIndex;
            PlayerSongNameTitle.Text = "";
            PlayerAlbumNameTitle.Text = "";
            PlayerArtistNameTitle.Text = "";
            PlayerSongLengthTitle.Text = "";

        }

        // On listBox item selected.
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable library management buttons.
            LibraryButtonUp.Enabled = true;
            LibraryButtonDown.Enabled = true;
        }

        private void PlayerButtonBack_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > 0 && listBox2.SelectedIndex != 0)
            {
                listBox2.SelectedIndex = listBox2.SelectedIndex - 1;
                UpdateSongInfo();
            }

        }

        // On next button clicked select next listbox object.
        private void PlayerButtonNext_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
            {
                listBox2.SelectedIndex = listBox2.SelectedIndex + 1;
                UpdateSongInfo();               
            }
        }

        // On back button clicked select previous listbox object.
        private void LibraryButtonUp_Click(object sender, EventArgs e)
        {

            // Checking selected item
            if (listBox2.SelectedItem == null || listBox2.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = listBox2.SelectedIndex - 1;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= listBox2.Items.Count)
                return; // Index out of range - nothing to do

            object selected = listBox2.SelectedItem;

            // Removing removable element
            listBox2.Items.Remove(selected);
            // Insert it in new position
            listBox2.Items.Insert(newIndex, selected);
            // Restore selection
            listBox2.SetSelected(newIndex, true);
        }

        private void LibraryButtonDown_Click(object sender, EventArgs e)
        {
            // Checking selected item
            if (listBox2.SelectedItem == null || listBox2.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = listBox2.SelectedIndex + 1;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= listBox2.Items.Count)
                return; // Index out of range - nothing to do

            object selected = listBox2.SelectedItem;

            // Removing removable element
            listBox2.Items.Remove(selected);
            // Insert it in new position
            listBox2.Items.Insert(newIndex, selected);
            // Restore selection
            listBox2.SetSelected(newIndex, true);

        }
    }
}
