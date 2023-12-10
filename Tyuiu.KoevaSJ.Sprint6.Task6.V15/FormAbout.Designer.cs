
namespace Tyuiu.KoevaSJ.Sprint6.Task6.V15
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.textBoxAbout_KSJ = new System.Windows.Forms.TextBox();
            this.buttonOk_KSJ = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_KSJ = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_KSJ)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAbout_KSJ
            // 
            this.textBoxAbout_KSJ.Location = new System.Drawing.Point(233, 33);
            this.textBoxAbout_KSJ.Multiline = true;
            this.textBoxAbout_KSJ.Name = "textBoxAbout_KSJ";
            this.textBoxAbout_KSJ.ReadOnly = true;
            this.textBoxAbout_KSJ.Size = new System.Drawing.Size(555, 263);
            this.textBoxAbout_KSJ.TabIndex = 0;
            this.textBoxAbout_KSJ.Text = resources.GetString("textBoxAbout_KSJ.Text");
            // 
            // buttonOk_KSJ
            // 
            this.buttonOk_KSJ.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonOk_KSJ.Location = new System.Drawing.Point(647, 319);
            this.buttonOk_KSJ.Name = "buttonOk_KSJ";
            this.buttonOk_KSJ.Size = new System.Drawing.Size(130, 47);
            this.buttonOk_KSJ.TabIndex = 1;
            this.buttonOk_KSJ.Text = "Ок";
            this.buttonOk_KSJ.UseVisualStyleBackColor = false;
            this.buttonOk_KSJ.Click += new System.EventHandler(this.buttonOk_KSJ_Click);
            // 
            // pictureBoxAvatar_KSJ
            // 
            this.pictureBoxAvatar_KSJ.Image = global::Tyuiu.KoevaSJ.Sprint6.Task6.V15.Properties.Resources.ФотоЯ;
            this.pictureBoxAvatar_KSJ.Location = new System.Drawing.Point(12, 59);
            this.pictureBoxAvatar_KSJ.Name = "pictureBoxAvatar_KSJ";
            this.pictureBoxAvatar_KSJ.Size = new System.Drawing.Size(197, 216);
            this.pictureBoxAvatar_KSJ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_KSJ.TabIndex = 2;
            this.pictureBoxAvatar_KSJ.TabStop = false;
            this.pictureBoxAvatar_KSJ.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.pictureBoxAvatar_KSJ);
            this.Controls.Add(this.buttonOk_KSJ);
            this.Controls.Add(this.textBoxAbout_KSJ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_KSJ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAbout_KSJ;
        private System.Windows.Forms.Button buttonOk_KSJ;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_KSJ;
    }
}