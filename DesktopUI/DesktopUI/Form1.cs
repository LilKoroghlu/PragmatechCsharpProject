using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopUI
{
    public partial class Form1 : Form
    {
        public bool clickedButton = false;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Height = 500;
            this.Width = 460;
            int horizontalButtonPlacement = 10;
            int verticalButtonPlacement = 10;
            bool buttonColor = true;
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    //  Button settings
                    Button button = new Button();
                    button.Width = 50;
                    button.Height = 50;
                    button.Left = horizontalButtonPlacement;
                    button.Top = verticalButtonPlacement;
                    horizontalButtonPlacement += 50;
                    button.BackColor = buttonColor ? ColorTranslator.FromHtml("#E4943E") : ColorTranslator.FromHtml("#783F10");
                    buttonColor = !buttonColor;

                    //  Position of starting  black figures
                    if (i == 0 && (j == 0 || j == 7)) button.Image = Image.FromFile(@"D:\C# Project\DesktopUI\DesktopUI\Images\RooksBlack.png");
                    else if (i == 0 && (j == 1 || j == 6)) button.Image = Image.FromFile(@"D:\C# Project\DesktopUI\DesktopUI\Images\KnightsBlack.png");
                    else if (i == 0 && (j == 2 || j == 5)) button.Image = Image.FromFile(@"D:\C# Project\DesktopUI\DesktopUI\Images\BishopsBlack.png");
                    else if (i == 0 && j == 3) button.Image = Image.FromFile(@"D:\C# Project\DesktopUI\DesktopUI\Images\QueenBlack.png");
                    else if (i == 0 && j == 4) button.Image = Image.FromFile(@"D:\C# Project\DesktopUI\DesktopUI\Images\KingBlack.png");
                    else if (i == 1) button.Image = Image.FromFile(@"D:\C# Project\DesktopUI\DesktopUI\Images\PawnsBlack.png");

                    //  Position of starting white figures
                    else if (i == 7 && (j == 0 || j == 7)) button.Image = Image.FromFile(@"D:\C# Project\DesktopUI\DesktopUI\Images\RooksWhite.png");
                    else if (i == 7 && (j == 1 || j == 6)) button.Image = Image.FromFile(@"D:\C# Project\DesktopUI\DesktopUI\Images\KnightsWhite.png");
                    else if (i == 7 && (j == 2 || j == 5)) button.Image = Image.FromFile(@"D:\C# Project\DesktopUI\DesktopUI\Images\BishopsWhite.png");
                    else if (i == 7 && j == 3) button.Image = Image.FromFile(@"D:\C# Project\DesktopUI\DesktopUI\Images\QueenWhite.png");
                    else if (i == 7 && j == 4) button.Image = Image.FromFile(@"D:\C# Project\DesktopUI\DesktopUI\Images\KingWhite.png");
                    else if (i == 6) button.Image = Image.FromFile(@"D:\C# Project\DesktopUI\DesktopUI\Images\PawnsWhite.png");

                    button.Click += new EventHandler(ButtonClicked);
                    this.Controls.Add(button);
                }
                buttonColor = !buttonColor;
                horizontalButtonPlacement = 10;
                verticalButtonPlacement += 50;
            }
        }
        void ButtonClicked(object sender, EventArgs args)
        {
            
        }
        
    }
}
