namespace FootballApp.UserControls
{
    partial class ControlPlayer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imagebutton = new System.Windows.Forms.PictureBox();
            this.Number_txt = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagebutton)).BeginInit();
            this.SuspendLayout();
            // 
            // imagebutton
            // 
            this.imagebutton.BackgroundImage = global::FootballApp.Resources.f;
            this.imagebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagebutton.Location = new System.Drawing.Point(3, 3);
            this.imagebutton.Name = "imagebutton";
            this.imagebutton.Size = new System.Drawing.Size(119, 123);
            this.imagebutton.TabIndex = 3;
            this.imagebutton.TabStop = false;
            // 
            // Number_txt
            // 
            this.Number_txt.AutoSize = true;
            this.Number_txt.BackColor = System.Drawing.Color.White;
            this.Number_txt.Location = new System.Drawing.Point(52, 63);
            this.Number_txt.Name = "Number_txt";
            this.Number_txt.Size = new System.Drawing.Size(17, 20);
            this.Number_txt.TabIndex = 4;
            this.Number_txt.Text = "0";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.ForeColor = System.Drawing.Color.Red;
            this.lbl_name.Location = new System.Drawing.Point(23, 97);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(51, 20);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "Name";
            // 
            // ControlPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.Number_txt);
            this.Controls.Add(this.imagebutton);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ControlPlayer";
            this.Size = new System.Drawing.Size(131, 129);
            ((System.ComponentModel.ISupportInitialize)(this.imagebutton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox imagebutton;
        private Label Number_txt;
        private Label lbl_name;
    }
}
