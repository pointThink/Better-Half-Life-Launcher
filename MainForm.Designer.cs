
namespace HLaunch
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.gameInput = new System.Windows.Forms.TextBox();
			this.Box = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.fov = new System.Windows.Forms.TextBox();
			this.console = new System.Windows.Forms.CheckBox();
			this.dontDrawHud = new System.Windows.Forms.CheckBox();
			this.SvCheats = new System.Windows.Forms.CheckBox();
			this.skiptrain = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.parms = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.addr = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pixelated = new System.Windows.Forms.CheckBox();
			this.maxspeed = new System.Windows.Forms.CheckBox();
			this.bob = new System.Windows.Forms.CheckBox();
			this.button2 = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.Box.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, -3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(269, 351);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(438, 316);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Run!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(293, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Game  Name";
			// 
			// gameInput
			// 
			this.gameInput.Location = new System.Drawing.Point(391, 10);
			this.gameInput.Name = "gameInput";
			this.gameInput.Size = new System.Drawing.Size(118, 20);
			this.gameInput.TabIndex = 2;
			// 
			// Box
			// 
			this.Box.Controls.Add(this.label3);
			this.Box.Controls.Add(this.fov);
			this.Box.Controls.Add(this.console);
			this.Box.Controls.Add(this.dontDrawHud);
			this.Box.Controls.Add(this.SvCheats);
			this.Box.Controls.Add(this.skiptrain);
			this.Box.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.Box.Location = new System.Drawing.Point(275, 59);
			this.Box.Name = "Box";
			this.Box.Size = new System.Drawing.Size(238, 109);
			this.Box.TabIndex = 4;
			this.Box.TabStop = false;
			this.Box.Text = "Useful";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Custom field of view";
			// 
			// fov
			// 
			this.fov.Location = new System.Drawing.Point(116, 80);
			this.fov.Name = "fov";
			this.fov.Size = new System.Drawing.Size(116, 20);
			this.fov.TabIndex = 4;
			// 
			// console
			// 
			this.console.Location = new System.Drawing.Point(116, 50);
			this.console.Name = "console";
			this.console.Size = new System.Drawing.Size(117, 24);
			this.console.TabIndex = 3;
			this.console.Text = "Developer Console";
			this.console.UseVisualStyleBackColor = true;
			// 
			// dontDrawHud
			// 
			this.dontDrawHud.Location = new System.Drawing.Point(116, 20);
			this.dontDrawHud.Name = "dontDrawHud";
			this.dontDrawHud.Size = new System.Drawing.Size(104, 24);
			this.dontDrawHud.TabIndex = 2;
			this.dontDrawHud.Text = "Disable Hud";
			this.dontDrawHud.UseVisualStyleBackColor = true;
			// 
			// SvCheats
			// 
			this.SvCheats.Location = new System.Drawing.Point(7, 50);
			this.SvCheats.Name = "SvCheats";
			this.SvCheats.Size = new System.Drawing.Size(104, 24);
			this.SvCheats.TabIndex = 1;
			this.SvCheats.Text = "sv_cheats";
			this.SvCheats.UseVisualStyleBackColor = true;
			// 
			// skiptrain
			// 
			this.skiptrain.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.skiptrain.Location = new System.Drawing.Point(7, 20);
			this.skiptrain.Name = "skiptrain";
			this.skiptrain.Size = new System.Drawing.Size(104, 24);
			this.skiptrain.TabIndex = 0;
			this.skiptrain.Tag = "skipTrainChecked";
			this.skiptrain.Text = "Skip train";
			this.skiptrain.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(275, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Additional Parameters";
			// 
			// parms
			// 
			this.parms.Location = new System.Drawing.Point(391, 36);
			this.parms.Name = "parms";
			this.parms.Size = new System.Drawing.Size(118, 20);
			this.parms.TabIndex = 6;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.addr);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.pixelated);
			this.groupBox1.Controls.Add(this.maxspeed);
			this.groupBox1.Controls.Add(this.bob);
			this.groupBox1.Location = new System.Drawing.Point(275, 174);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(238, 140);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Other";
			// 
			// addr
			// 
			this.addr.Location = new System.Drawing.Point(74, 105);
			this.addr.Name = "addr";
			this.addr.Size = new System.Drawing.Size(146, 20);
			this.addr.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(7, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Connect to";
			// 
			// pixelated
			// 
			this.pixelated.Location = new System.Drawing.Point(6, 77);
			this.pixelated.Name = "pixelated";
			this.pixelated.Size = new System.Drawing.Size(136, 24);
			this.pixelated.TabIndex = 2;
			this.pixelated.Text = "Disable texture filtering";
			this.toolTip1.SetToolTip(this.pixelated, "Makes textures pixelated");
			this.pixelated.UseVisualStyleBackColor = true;
			this.pixelated.CheckedChanged += new System.EventHandler(this.Pixelated_CheckedChanged);
			// 
			// maxspeed
			// 
			this.maxspeed.Location = new System.Drawing.Point(6, 47);
			this.maxspeed.Name = "maxspeed";
			this.maxspeed.Size = new System.Drawing.Size(214, 24);
			this.maxspeed.TabIndex = 1;
			this.maxspeed.Text = "Set maxspeed to 400";
			this.maxspeed.UseVisualStyleBackColor = true;
			// 
			// bob
			// 
			this.bob.Location = new System.Drawing.Point(7, 19);
			this.bob.Name = "bob";
			this.bob.Size = new System.Drawing.Size(135, 24);
			this.bob.TabIndex = 0;
			this.bob.Text = "Disable view bobbing";
			this.bob.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(357, 316);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(517, 343);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.parms);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gameInput);
			this.Controls.Add(this.Box);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Better Half-Life Launcher";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.Box.ResumeLayout(false);
			this.Box.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox addr;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.CheckBox bob;
		private System.Windows.Forms.CheckBox maxspeed;
		private System.Windows.Forms.CheckBox pixelated;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox console;
		private System.Windows.Forms.TextBox fov;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox dontDrawHud;
		private System.Windows.Forms.CheckBox SvCheats;
		public System.Windows.Forms.CheckBox skiptrain;
		private System.Windows.Forms.TextBox parms;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox Box;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox gameInput;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
