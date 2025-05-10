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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DeleteUser = new MetroFramework.Controls.MetroTile();
            this.SearchUser = new MetroFramework.Controls.MetroTile();
            this.AddUser = new MetroFramework.Controls.MetroTile();
            this.UserAdminGrid = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.UserAdminGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteUser
            // 
            this.DeleteUser.ActiveControl = null;
            this.DeleteUser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.DeleteUser.Location = new System.Drawing.Point(152, 308);
            this.DeleteUser.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(71, 40);
            this.DeleteUser.TabIndex = 9;
            this.DeleteUser.Text = "Sterge";
            this.DeleteUser.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.DeleteUser.UseCustomBackColor = true;
            this.DeleteUser.UseSelectable = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // SearchUser
            // 
            this.SearchUser.ActiveControl = null;
            this.SearchUser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SearchUser.Location = new System.Drawing.Point(78, 308);
            this.SearchUser.Margin = new System.Windows.Forms.Padding(2);
            this.SearchUser.Name = "SearchUser";
            this.SearchUser.Size = new System.Drawing.Size(71, 40);
            this.SearchUser.TabIndex = 8;
            this.SearchUser.Text = "Cauta";
            this.SearchUser.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.SearchUser.UseCustomBackColor = true;
            this.SearchUser.UseSelectable = true;
            this.SearchUser.Click += new System.EventHandler(this.SearchUser_Click);
            // 
            // AddUser
            // 
            this.AddUser.ActiveControl = null;
            this.AddUser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.AddUser.Location = new System.Drawing.Point(3, 308);
            this.AddUser.Margin = new System.Windows.Forms.Padding(2);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(71, 40);
            this.AddUser.TabIndex = 7;
            this.AddUser.Text = "Adauga";
            this.AddUser.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.AddUser.UseCustomBackColor = true;
            this.AddUser.UseSelectable = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // UserAdminGrid
            // 
            this.UserAdminGrid.AllowUserToResizeRows = false;
            this.UserAdminGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.UserAdminGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserAdminGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UserAdminGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserAdminGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.UserAdminGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserAdminGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.UserAdminGrid.EnableHeadersVisualStyles = false;
            this.UserAdminGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserAdminGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UserAdminGrid.Location = new System.Drawing.Point(3, 3);
            this.UserAdminGrid.Name = "UserAdminGrid";
            this.UserAdminGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserAdminGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.UserAdminGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.UserAdminGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserAdminGrid.Size = new System.Drawing.Size(614, 300);
            this.UserAdminGrid.TabIndex = 10;
            this.UserAdminGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // UserAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UserAdminGrid);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.SearchUser);
            this.Controls.Add(this.AddUser);
            this.Name = "UserAdminControl";
            this.Size = new System.Drawing.Size(620, 358);
            this.Load += new System.EventHandler(this.UserAdminControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserAdminGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile DeleteUser;
        private MetroFramework.Controls.MetroTile SearchUser;
        private MetroFramework.Controls.MetroTile AddUser;
        private MetroFramework.Controls.MetroGrid UserAdminGrid;
    }
}
