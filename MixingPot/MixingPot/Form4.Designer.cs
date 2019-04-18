namespace MixingPot
{
	partial class Form4
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
			this.label1 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.userControl11 = new MixingPot.UserControl1();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(547, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(401, 78);
			this.label1.TabIndex = 6;
			this.label1.Text = "Assign Groups";
			// 
			// button3
			// 
			this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.button3.Location = new System.Drawing.Point(1196, 308);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(119, 32);
			this.button3.TabIndex = 8;
			this.button3.Text = "Add another location";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// userControl11
			// 
			this.userControl11.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.userControl11.Location = new System.Drawing.Point(97, 175);
			this.userControl11.Name = "userControl11";
			this.userControl11.Size = new System.Drawing.Size(1300, 127);
			this.userControl11.TabIndex = 10;
			// 
			// button2
			// 
			this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button2.Location = new System.Drawing.Point(1203, 80);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 45);
			this.button2.TabIndex = 11;
			this.button2.Text = "Finish and Display Groups";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1478, 830);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.userControl11);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label1);
			this.Name = "Form4";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MixingPot - Select Groups";
			this.Load += new System.EventHandler(this.Form4_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
		private UserControl1 userControl11;
		private System.Windows.Forms.Button button2;
	}

}