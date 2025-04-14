namespace ComponenteProiect
{
    partial class UserAdminControl
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
            this.UserAdminLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // UserAdminLabel
            // 
            this.UserAdminLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserAdminLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.UserAdminLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.UserAdminLabel.Location = new System.Drawing.Point(21, 15);
            this.UserAdminLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserAdminLabel.Name = "UserAdminLabel";
            this.UserAdminLabel.Size = new System.Drawing.Size(214, 48);
            this.UserAdminLabel.TabIndex = 5;
            this.UserAdminLabel.Text = "Administrare Utilizatori";
            this.UserAdminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UserAdminLabel.UseCustomBackColor = true;
            this.UserAdminLabel.WrapToLine = true;
            this.UserAdminLabel.Click += new System.EventHandler(this.UserAdminLabel_Click);
            // 
            // UserAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UserAdminLabel);
            this.Name = "UserAdminControl";
            this.Size = new System.Drawing.Size(620, 358);
            this.Load += new System.EventHandler(this.UserAdminControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel UserAdminLabel;
    }
}
