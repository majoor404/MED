using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
