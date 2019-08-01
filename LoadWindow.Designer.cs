namespace MED
{
    partial class LoadWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelOnder = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelDrive = new System.Windows.Forms.Panel();
            this.panelFolder = new System.Windows.Forms.Panel();
            this.panelOnder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOnder
            // 
            this.panelOnder.Controls.Add(this.panelFolder);
            this.panelOnder.Controls.Add(this.panelDrive);
            this.panelOnder.Controls.Add(this.label4);
            this.panelOnder.Controls.Add(this.label3);
            this.panelOnder.Controls.Add(this.label2);
            this.panelOnder.Controls.Add(this.label1);
            this.panelOnder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOnder.Location = new System.Drawing.Point(0, 0);
            this.panelOnder.Name = "panelOnder";
            this.panelOnder.Padding = new System.Windows.Forms.Padding(5);
            this.panelOnder.Size = new System.Drawing.Size(911, 512);
            this.panelOnder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(93, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drive";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(93, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Folder";
            // 
            // panelDrive
            // 
            this.panelDrive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDrive.Location = new System.Drawing.Point(154, 12);
            this.panelDrive.Name = "panelDrive";
            this.panelDrive.Size = new System.Drawing.Size(745, 59);
            this.panelDrive.TabIndex = 4;
            // 
            // panelFolder
            // 
            this.panelFolder.Location = new System.Drawing.Point(154, 96);
            this.panelFolder.Name = "panelFolder";
            this.panelFolder.Size = new System.Drawing.Size(745, 59);
            this.panelFolder.TabIndex = 5;
            // 
            // LoadWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 512);
            this.Controls.Add(this.panelOnder);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadWindow";
            this.Text = "LoadWindow";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoadWindow_KeyPress);
            this.panelOnder.ResumeLayout(false);
            this.panelOnder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOnder;
        private System.Windows.Forms.Panel panelFolder;
        private System.Windows.Forms.Panel panelDrive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}