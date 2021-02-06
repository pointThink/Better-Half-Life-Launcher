
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace HLaunch
{
	
	public partial class MainForm : Form
	{
		public string runCommand;
		public string hlExec;
				
		public MainForm()
		{
			InitializeComponent();
			
		}
		
		void MainForm_Load(object sender, EventArgs e)
		{
			StreamReader readFile = new StreamReader(@"hlpath.txt");
			
			hlExec = readFile.ReadLine();	
		}
		
		void Button1_Click(object sender, EventArgs e)
		{
			// Run
			
			if (gameInput.Text != "") {
			
				runCommand = runCommand + " -game " + gameInput.Text;
			
			}
			
			if (skiptrain.Checked == true ) {
				
				runCommand = runCommand + " +map c1a0 ";
				
			}
			
			if (SvCheats.Checked == true) {
			
				runCommand = runCommand + " +sv_cheats 1 ";
			
			}
			
			if (dontDrawHud.Checked == true) {
			
				runCommand = runCommand + " -hud_draw 0 ";
			
			}
			
			if (console.Checked == true) {
			
				runCommand = runCommand + " -console ";
			
			}
			
			if (fov.Text != "") {
			
				runCommand = runCommand + " +default_fov " + fov.Text.ToString() + "";
			
			}
			
			if (bob.Checked == true) {
			
				runCommand = runCommand + " +cl_bob 0";
			
			}
			
			if (maxspeed.Checked == true) {
			
				runCommand = runCommand + " +sv_maxspeed 400 ";
			
			}
			
			if (pixelated.Checked == true) {
			
				runCommand = runCommand + " +gl_texturemode gl_nearest ";
			
			}
			
			if (addr.Text != "") {
			
				runCommand = runCommand + " +connect " + addr.Text + " ";
			
			}
			
			if (parms.Text != "") {
			
				runCommand = runCommand + " " + parms.Text + " ";
				
			}
			
			System.Diagnostics.Process.Start(hlExec, runCommand);
			
			this.Close();
			
		}
		
		void Button2_Click(object sender, EventArgs e)
		{
			// Cancel
			this.Close();
		}
		
		void Pixelated_CheckedChanged(object sender, EventArgs e)
		{
			
		}
	}
}
