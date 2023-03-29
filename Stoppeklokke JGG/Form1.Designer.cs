namespace Stoppeklokke_JGG
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BttnStart = new System.Windows.Forms.Button();
            this.BttnStop = new System.Windows.Forms.Button();
            this.BttnReset = new System.Windows.Forms.Button();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BttnStart
            // 
            this.BttnStart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BttnStart.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnStart.Location = new System.Drawing.Point(100, 325);
            this.BttnStart.Name = "BttnStart";
            this.BttnStart.Size = new System.Drawing.Size(172, 66);
            this.BttnStart.TabIndex = 0;
            this.BttnStart.Text = "Start";
            this.BttnStart.UseVisualStyleBackColor = false;
            this.BttnStart.Click += new System.EventHandler(this.BttnStart_Click);
            // 
            // BttnStop
            // 
            this.BttnStop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BttnStop.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnStop.Location = new System.Drawing.Point(278, 325);
            this.BttnStop.Name = "BttnStop";
            this.BttnStop.Size = new System.Drawing.Size(172, 66);
            this.BttnStop.TabIndex = 1;
            this.BttnStop.Text = "Stop";
            this.BttnStop.UseVisualStyleBackColor = false;
            this.BttnStop.Click += new System.EventHandler(this.BttnStop_Click);
            // 
            // BttnReset
            // 
            this.BttnReset.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BttnReset.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnReset.Location = new System.Drawing.Point(467, 325);
            this.BttnReset.Name = "BttnReset";
            this.BttnReset.Size = new System.Drawing.Size(172, 66);
            this.BttnReset.TabIndex = 2;
            this.BttnReset.Text = "Reset";
            this.BttnReset.UseVisualStyleBackColor = false;
            this.BttnReset.Click += new System.EventHandler(this.BttnReset_Click);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Product Sans", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(88, 94);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(174, 122);
            this.lblHour.TabIndex = 3;
            this.lblHour.Text = "00";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Product Sans", 75F);
            this.lblMin.Location = new System.Drawing.Point(268, 90);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(182, 128);
            this.lblMin.TabIndex = 4;
            this.lblMin.Text = "00";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("Product Sans", 37F);
            this.lblSec.Location = new System.Drawing.Point(456, 138);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(91, 63);
            this.lblSec.TabIndex = 5;
            this.lblSec.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Product Sans", 75F);
            this.label1.Location = new System.Drawing.Point(227, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 128);
            this.label1.TabIndex = 6;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 37F);
            this.label2.Location = new System.Drawing.Point(420, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 63);
            this.label2.TabIndex = 7;
            this.label2.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.BttnReset);
            this.Controls.Add(this.BttnStop);
            this.Controls.Add(this.BttnStart);
            this.Controls.Add(this.lblHour);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Stoppeklokke";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BttnStart;
        private System.Windows.Forms.Button BttnStop;
        private System.Windows.Forms.Button BttnReset;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

