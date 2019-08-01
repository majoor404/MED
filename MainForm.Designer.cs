namespace MED
{
    partial class MainForm
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
            this.panelText = new System.Windows.Forms.Panel();
            this.Tekst = new System.Windows.Forms.TextBox();
            this.panelCommando = new System.Windows.Forms.Panel();
            this.textBoxCommando = new System.Windows.Forms.TextBox();
            this.panelText.SuspendLayout();
            this.panelCommando.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelText
            // 
            this.panelText.Controls.Add(this.Tekst);
            this.panelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelText.Location = new System.Drawing.Point(0, 0);
            this.panelText.Margin = new System.Windows.Forms.Padding(0);
            this.panelText.Name = "panelText";
            this.panelText.Size = new System.Drawing.Size(800, 450);
            this.panelText.TabIndex = 3;
            // 
            // Tekst
            // 
            this.Tekst.BackColor = System.Drawing.Color.Black;
            this.Tekst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tekst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tekst.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tekst.ForeColor = System.Drawing.Color.White;
            this.Tekst.Location = new System.Drawing.Point(0, 0);
            this.Tekst.Margin = new System.Windows.Forms.Padding(0);
            this.Tekst.Multiline = true;
            this.Tekst.Name = "Tekst";
            this.Tekst.Size = new System.Drawing.Size(800, 450);
            this.Tekst.TabIndex = 3;
            this.Tekst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // panelCommando
            // 
            this.panelCommando.Controls.Add(this.textBoxCommando);
            this.panelCommando.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCommando.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCommando.Location = new System.Drawing.Point(0, 431);
            this.panelCommando.Margin = new System.Windows.Forms.Padding(0);
            this.panelCommando.Name = "panelCommando";
            this.panelCommando.Size = new System.Drawing.Size(800, 19);
            this.panelCommando.TabIndex = 4;
            // 
            // textBoxCommando
            // 
            this.textBoxCommando.BackColor = System.Drawing.Color.Black;
            this.textBoxCommando.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCommando.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCommando.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCommando.ForeColor = System.Drawing.Color.White;
            this.textBoxCommando.Location = new System.Drawing.Point(0, 0);
            this.textBoxCommando.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxCommando.Name = "textBoxCommando";
            this.textBoxCommando.Size = new System.Drawing.Size(800, 19);
            this.textBoxCommando.TabIndex = 3;
            this.textBoxCommando.TextChanged += new System.EventHandler(this.TextBoxCommando_TextChanged);
            this.textBoxCommando.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCommando_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCommando);
            this.Controls.Add(this.panelText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Med";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.panelText.ResumeLayout(false);
            this.panelText.PerformLayout();
            this.panelCommando.ResumeLayout(false);
            this.panelCommando.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelText;
        private System.Windows.Forms.TextBox Tekst;
        private System.Windows.Forms.Panel panelCommando;
        private System.Windows.Forms.TextBox textBoxCommando;
    }
}

