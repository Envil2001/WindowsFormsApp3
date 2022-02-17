using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private SqlConnection sql = null;
        //INSERT INTO [User] (Name, password1, password2) VALUES ('qwrqwr', 222, 222)
        Panel pTop = new Panel();
        Panel pBottom = new Panel();
        RjControls.RJTextBox user = new RjControls.RJTextBox();
        RjControls.RJTextBox pasv1 = new RjControls.RJTextBox();
        RjControls.RJTextBox pasv2 = new RjControls.RJTextBox();

        Label userLb = new Label();
        Label pasv1Lb = new Label();
        Label pasv2Lb = new Label();

        Button sign = new Button();
        Button exit = new Button();
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(400, 800);
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackgroundImage = Properties.Resources.mountainsjpg;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            pTop.Size = new Size(200, 200);

            pTop.BackgroundImage = Properties.Resources.unnamed;
            pTop.BackColor = Color.Transparent;
            pTop.BackgroundImageLayout = ImageLayout.Stretch;
            pTop.Location = new Point(85, 80);

            this.Controls.Add(pTop);
            this.Controls.Add(pBottom);
            this.Controls.Add(exit);

            pBottom.Controls.Add(user);
            pBottom.Controls.Add(pasv1);
            pBottom.Controls.Add(pasv2);
            pBottom.Controls.Add(userLb);
            pBottom.Controls.Add(pasv1Lb);
            pBottom.Controls.Add(pasv2Lb);
            pBottom.Controls.Add(sign);


            pBottom.Size = new Size(343, 300);
            pBottom.BackColor = ColorTranslator.FromHtml("#ede8f6");
            pBottom.Location = new Point(20, 400);

            user.Location = new Point(20, 40);
            pasv1.Location = new Point(20, 100);
            pasv2.Location = new Point(20, 160);

            pasv1.Size = new Size(300, 250);
            pasv2.Size = new Size(300, 150);
            user.Size = new Size(300, 150);

            sign.Click += new EventHandler(Riest_Click);
            sign.Text = "Sign In";
            sign.ForeColor = Color.White;
            sign.Font = new Font("Verdana", 11);
            sign.Location = new Point(20, 220);
            sign.Size = new Size(300, 50);
            sign.BackColor = Color.MediumPurple;
            sign.FlatAppearance.BorderSize = 0;
            sign.FlatStyle = FlatStyle.Flat;

            exit.Click += exit_Click;
            exit.Text = "х";
            exit.ForeColor = Color.White;
            exit.BackColor = Color.MediumPurple;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Location = new Point(364, 0);
            exit.Size = new Size(20, 20);
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatStyle = FlatStyle.Flat;

            userLb.Text = "Username";
            userLb.Location = new Point(20, 20);

            pasv1Lb.Text = "Password 1";
            pasv1Lb.Location = new Point(20, 80);

            pasv2Lb.Text = "Password 2";
            pasv2Lb.Location = new Point(20, 140);
        }


        private void Riest_Click(object sender, EventArgs e) {

            sql = new SqlConnection(ConfigurationManager.ConnectionStrings["WindowsFormsApp3.Properties.Settings.bdConnectionString"].ConnectionString);
            sql.Open();
            if(sql.State != ConnectionState.Open)
            {
                MessageBox.Show("Not Connection!");
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

    }
}
