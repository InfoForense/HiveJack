﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiveJack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process sam = new Process();
            sam.StartInfo.Verb = "runas";
            sam.StartInfo.FileName = "cmd.exe";
            sam.StartInfo.Arguments = "/c reg.exe save hklm\\sam c:\\temp\\sam.save";
            sam.StartInfo.UseShellExecute = false;
            sam.StartInfo.RedirectStandardOutput = true;
            sam.StartInfo.RedirectStandardError = true;
            sam.Start();
            //* Read the output (or the error)
            string output = sam.StandardOutput.ReadToEnd();
            textBox1.Text = output;
            sam.WaitForExit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process secu = new Process();
            secu.StartInfo.Verb = "runas";
            secu.StartInfo.FileName = "cmd.exe";
            secu.StartInfo.Arguments = "/c reg.exe save hklm\\security c:\\temp\\security.save";
            secu.StartInfo.UseShellExecute = false;
            secu.StartInfo.RedirectStandardOutput = true;
            secu.StartInfo.RedirectStandardError = true;
            secu.Start();
            //* Read the output (or the error)
            string output2 = secu.StandardOutput.ReadToEnd();
            textBox1.Text = output2;
            secu.WaitForExit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process syst = new Process();
            syst.StartInfo.Verb = "runas";
            syst.StartInfo.FileName = "cmd.exe";
            syst.StartInfo.Arguments = "/c reg.exe save hklm\\system c:\\temp\\system.save";
            syst.StartInfo.UseShellExecute = false;
            syst.StartInfo.RedirectStandardOutput = true;
            syst.StartInfo.RedirectStandardError = true;
            syst.Start();
            //* Read the output (or the error)
            string output3 = syst.StandardOutput.ReadToEnd();
            textBox1.Text = output3;
            syst.WaitForExit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process cle = new Process();
            cle.StartInfo.Verb = "runas";
            cle.StartInfo.FileName = "cmd.exe";
            cle.StartInfo.Arguments = "/c DEL /S /Q c:\\temp\\*.save";
            cle.StartInfo.UseShellExecute = false;
            cle.StartInfo.RedirectStandardOutput = true;
            cle.StartInfo.RedirectStandardError = true;
            cle.Start();
            //* Read the output (or the error)
            string output4 = cle.StandardOutput.ReadToEnd();
            textBox1.Text = output4;
            cle.WaitForExit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process op1 = new Process();
            op1.StartInfo.Verb = "runas";
            op1.StartInfo.FileName = "cmd.exe";
            op1.StartInfo.Arguments = "/c start c:\\temp\\";
            op1.StartInfo.UseShellExecute = false;
            op1.StartInfo.RedirectStandardOutput = true;
            op1.StartInfo.RedirectStandardError = true;
            op1.Start();
            //* Read the output (or the error)
            string output5 = op1.StandardOutput.ReadToEnd();
            textBox1.Text = output5;
            op1.WaitForExit();
        }
    }
}
