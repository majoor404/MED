using System.IO;
using System.Windows.Forms;

namespace MED
{
    public partial class LoadWindow : Form
    {
        public LoadWindow()
        {
            InitializeComponent();
        }

        private void LoadWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                    panelDrive.BorderStyle = BorderStyle.FixedSingle;
                    panelFolder.BorderStyle = BorderStyle.None;
                    break;
                case '2':
                    panelDrive.BorderStyle = BorderStyle.None;
                    panelFolder.BorderStyle = BorderStyle.FixedSingle;
                    break;
                case 'q':
                    Close();
                    break;
            }
        }

        private void LoadWindow_Shown(object sender, System.EventArgs e)
        {
            DriveInfo[] ListAllDrives = DriveInfo.GetDrives();

            foreach (DriveInfo Drive in ListAllDrives)
            {
                //Create ListViewItem, give name etc.
                ListViewItem NewItem = new ListViewItem();
                NewItem.Text = Drive.Name;
                listViewDrives.Items.Add(NewItem);
            }
        }
    }
}
