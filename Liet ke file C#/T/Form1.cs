using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace T
{
    public partial class Form1 : Form
    {
        LietKe lietKe;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Hàm liệt kê file.
        //List<string> AllFiles = new List<string>();
        //public void ParsePath(string path)
        //{
        //    try
        //    {
        //        string[] SubDirs = Directory.GetDirectories(path,"*p*");
        //        AllFiles.AddRange(SubDirs);
        //        AllFiles.AddRange(Directory.GetFiles(path,"*p*"));
        //        foreach (string subdir in SubDirs)
        //            ParsePath(subdir);
        //    }

        //public void tenFile(string text, List<string> FileAll)
        //{

        //    try
        //    {

        //        string[] dir = Directory.GetFiles(text, "*p*");
        //        foreach (string d in dir)
        //        {
        //            FileAll.Add(d);
        //        }
        //        string[] files = Directory.GetDirectories(text, "*p*");
        //        foreach (string n in files)
        //        {
        //            tenFile(n, FileAll);
        //        }
        //    }

        //    catch (Exception e)
        //    {
        //        MessageBox.Show("The process failed!", e.Message);
        //    }
        //}
        private void btnLietKe_Click(object sender, EventArgs e)
        {
            lietKe = new LietKe();
            lietKe.file(tbDirectory.Text, tbKeyword.Text, txtOutput);
            lblKQ.Text = lietKe.Count.ToString();
            MessageBox.Show("You have listed the file", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void txtXuat_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            ////Sau khi đếm xong click vào exit và Q thì hiện thị thông báo
            //if (e.KeyCode == (Keys.Q))
            //{
            //    DialogResult result;
            //    result = MessageBox.Show("Bạn có thực sự muốn dừng?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //    if (result == DialogResult.OK)
            //    {
            //        Application.Exit();
            //    }
            //}
            //if (Control.ModifierKeys == Keys.Q)
            //    lietKe.Stop = true;
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //    if (Control.ModifierKeys == Keys.Q)
            //        lietKe.Stop = true;
        }

        private void btnLietKe_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btnLietKe_KeyDown(object sender, KeyEventArgs e)
        {
                
        }
        private void txtOutput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Q))
            {
                DialogResult result;
                result = MessageBox.Show("Do you really want to exit?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Application.Exit();

                }
                txtOutput.Focus();
            }
         }

        private void txtOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (Control.ModifierKeys == Keys.Q)
            //    lietKe.Stop = true;
           
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //if (Control.ModifierKeys == Keys.Q)
            //    lietKe.Stop = true;
        }

        private void txtOutput_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you really want to exit?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();

            }
        }
    }
 }


