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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EditUser = new MetroFramework.Controls.MetroTile();
            this.SearchUser = new MetroFramework.Controls.MetroTile();
            this.AddUser = new MetroFramework.Controls.MetroTile();
            this.UserAdminGrid = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.UserAdminGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EditUser
            // 
            this.EditUser.ActiveControl = null;
            this.EditUser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.EditUser.Location = new System.Drawing.Point(152, 308);
            this.EditUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditUser.Name = "EditUser";
            this.EditUser.Size = new System.Drawing.Size(71, 40);
            this.EditUser.TabIndex = 9;
            this.EditUser.Text = "Editeaza";
            this.EditUser.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.EditUser.UseCustomBackColor = true;
            this.EditUser.UseSelectable = true;
            this.EditUser.Click += new System.EventHandler(this.EditUser_Click);
            // 
            // SearchUser
            // 
            this.SearchUser.ActiveControl = null;
            this.SearchUser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SearchUser.Location = new System.Drawing.Point(78, 308);
            this.SearchUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.AddUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserAdminGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UserAdminGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserAdminGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.UserAdminGrid.EnableHeadersVisualStyles = false;
            this.UserAdminGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserAdminGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UserAdminGrid.Location = new System.Drawing.Point(3, 3);
            this.UserAdminGrid.Name = "UserAdminGrid";
            this.UserAdminGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserAdminGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.UserAdminGrid.RowHeadersWidth = 51;
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
            this.Controls.Add(this.EditUser);
            this.Controls.Add(this.SearchUser);
            this.Controls.Add(this.AddUser);
            this.Name = "UserAdminControl";
            this.Size = new System.Drawing.Size(620, 358);
            this.Load += new System.EventHandler(this.UserAdminControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserAdminGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile EditUser;
        private MetroFramework.Controls.MetroTile SearchUser;
        private MetroFramework.Controls.MetroTile AddUser;
        private MetroFramework.Controls.MetroGrid UserAdminGrid;
    }
}
