﻿using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComponenteProiect
{
    public partial class MainMenu: MetroForm
    {
        MainMenuControl mainMenuControl = new MainMenuControl();
        UserAdminControl userAdminControl = new UserAdminControl(); 
        CalculatoareAdminControl calculatoareAdminControl = new CalculatoareAdminControl();
        string activeGrid = "main";
        public MainMenu()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            mainPanel.Controls.Add(mainMenuControl);
            initTiles();
        }

        private void initTiles()
        {
            foreach (Control control in sideBarPanel.Controls)
                if (control is MetroPanel)
                {
                    foreach (Control panel in control.Controls)
                    {
                        if (panel is MetroTile tile)
                        {
                            tile.TabStop = false;
                            tile.MouseEnter += MainMenuTile_MouseEnter;
                            tile.Enter += MainMenuTile_Enter;
                            tile.MouseLeave += MainMenuTile_MouseLeave;
                        }
                    }
                }
        }

        private void changeToGreen(MetroTile tile)
        {
            if (tile == Admin_Calculatoare)
            {
                this.Admin_Calculatoare.TileImage = global::ComponenteProiect.Properties.Resources.gaming_pc_darkgreen;
            }
            else if(tile == Useri_Comenzi)
            {
                this.Useri_Comenzi.TileImage = global::ComponenteProiect.Properties.Resources.DarkGreenUser;
            }
            else if(tile == MainMenuTile)
            {
                this.MainMenuTile.TileImage = global::ComponenteProiect.Properties.Resources.MenuDarkGreen;
            }
            
        }

        private void changeToBlack(MetroTile tile)
        {
            if (tile == Admin_Calculatoare)
            {

                this.Admin_Calculatoare.TileImage = global::ComponenteProiect.Properties.Resources.gaming_pc__1_;
            }
            else if (tile == Useri_Comenzi)
            {
                this.Useri_Comenzi.TileImage = global::ComponenteProiect.Properties.Resources.user1;
            }
            else if (tile == MainMenuTile)
            {
                this.MainMenuTile.TileImage = global::ComponenteProiect.Properties.Resources.blackMenu;
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(calculatoareAdminControl);
            activeGrid = "calculatoare";
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.ActiveControl = meniuriLabel;
        }

        private void Useri_Comenzi_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userAdminControl);
            activeGrid = "useri";
        }

        private void MainMenuTile_MouseLeave(object sender, EventArgs e)
        {
            ((MetroFramework.Controls.MetroTile)sender).ForeColor = Color.Black;
            changeToBlack((MetroFramework.Controls.MetroTile)sender);
        }

        private void MainMenuTile_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(mainMenuControl);
            activeGrid = "main";

        }

        private void MainMenuTile_Enter(object sender, EventArgs e)
        {
            ((MetroFramework.Controls.MetroTile)sender).ForeColor = Color.DarkGreen;
        }

        private void MainMenuTile_MouseEnter(object sender, EventArgs e)
        {
            ((MetroFramework.Controls.MetroTile)sender).ForeColor = Color.DarkGreen;
            changeToGreen((MetroFramework.Controls.MetroTile)sender);
        }


        private void Refresh_Click(object sender, EventArgs e)
        {
            if (activeGrid == "calculatoare")
            {
                calculatoareAdminControl.refreshGrid();
            }
            else if (activeGrid == "useri")
            {
                userAdminControl.refreshGrid();
            }
            else if (activeGrid == "main")
            {
                mainMenuControl.refreshGrids();
            }
        }

    }
}
