namespace ComponenteProiect
{
    partial class UsersForm
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
            this.Back = new MetroFramework.Controls.MetroButton();
            this.AddUser = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.RosyBrown;
            this.Back.Location = new System.Drawing.Point(383, 313);
            this.Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 28);
            this.Back.TabIndex = 0;
            this.Back.Text = "Inapoi";
            this.Back.UseCustomBackColor = true;
            this.Back.UseSelectable = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AddUser
            // 
            this.AddUser.ActiveControl = null;
            this.AddUser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.AddUser.Location = new System.Drawing.Point(29, 78);
            this.AddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(200, 49);
            this.AddUser.TabIndex = 1;
            this.AddUser.Text = "Adauga Utilizator";
            this.AddUser.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.AddUser.UseCustomBackColor = true;
            this.AddUser.UseSelectable = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.metroTile2.Location = new System.Drawing.Point(29, 139);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(200, 49);
            this.metroTile2.TabIndex = 2;
            this.metroTile2.Text = "Cauta Utilizator";
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.metroTile3.Location = new System.Drawing.Point(29, 201);
            this.metroTile3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(200, 49);
            this.metroTile3.TabIndex = 3;
            this.metroTile3.Text = "Sterge Utilizator";
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile3.UseCustomBackColor = true;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.Back);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UsersForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Back;
        private MetroFramework.Controls.MetroTile AddUser;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
    }
}