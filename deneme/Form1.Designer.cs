
namespace deneme
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
            this.pContainer = new System.Windows.Forms.Panel();
            this.btnTimerTab1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimer2 = new System.Windows.Forms.Button();
            this.pContainer2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnTimer1Stop = new System.Windows.Forms.Button();
            this.btnTimer2Stop = new System.Windows.Forms.Button();
            this.pContainer3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pContainer4 = new System.Windows.Forms.Panel();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pContainer
            // 
            this.pContainer.Location = new System.Drawing.Point(12, 62);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(580, 243);
            this.pContainer.TabIndex = 0;
            // 
            // btnTimerTab1
            // 
            this.btnTimerTab1.Location = new System.Drawing.Point(32, 33);
            this.btnTimerTab1.Name = "btnTimerTab1";
            this.btnTimerTab1.Size = new System.Drawing.Size(75, 23);
            this.btnTimerTab1.TabIndex = 1;
            this.btnTimerTab1.Text = "Timer1";
            this.btnTimerTab1.UseVisualStyleBackColor = true;
            this.btnTimerTab1.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "1";
            // 
            // btnTimer2
            // 
            this.btnTimer2.Location = new System.Drawing.Point(29, 349);
            this.btnTimer2.Name = "btnTimer2";
            this.btnTimer2.Size = new System.Drawing.Size(75, 23);
            this.btnTimer2.TabIndex = 3;
            this.btnTimer2.Text = "Timer2";
            this.btnTimer2.UseVisualStyleBackColor = true;
            this.btnTimer2.Click += new System.EventHandler(this.btnTimer2_Click);
            // 
            // pContainer2
            // 
            this.pContainer2.Location = new System.Drawing.Point(13, 381);
            this.pContainer2.Name = "pContainer2";
            this.pContainer2.Size = new System.Drawing.Size(579, 217);
            this.pContainer2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "2";
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnTimer1Stop
            // 
            this.btnTimer1Stop.Location = new System.Drawing.Point(114, 33);
            this.btnTimer1Stop.Name = "btnTimer1Stop";
            this.btnTimer1Stop.Size = new System.Drawing.Size(75, 23);
            this.btnTimer1Stop.TabIndex = 5;
            this.btnTimer1Stop.Text = "Timer1Stop";
            this.btnTimer1Stop.UseVisualStyleBackColor = true;
            this.btnTimer1Stop.Click += new System.EventHandler(this.btnTimer1Stop_Click);
            // 
            // btnTimer2Stop
            // 
            this.btnTimer2Stop.Location = new System.Drawing.Point(111, 349);
            this.btnTimer2Stop.Name = "btnTimer2Stop";
            this.btnTimer2Stop.Size = new System.Drawing.Size(75, 23);
            this.btnTimer2Stop.TabIndex = 6;
            this.btnTimer2Stop.Text = "Timer2 Stop";
            this.btnTimer2Stop.UseVisualStyleBackColor = true;
            this.btnTimer2Stop.Click += new System.EventHandler(this.btnTimer2Stop_Click);
            // 
            // pContainer3
            // 
            this.pContainer3.Location = new System.Drawing.Point(598, 62);
            this.pContainer3.Name = "pContainer3";
            this.pContainer3.Size = new System.Drawing.Size(580, 246);
            this.pContainer3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Timer3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(699, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Timer3Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(617, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Timer4";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(699, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Timer4 Stop";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pContainer4
            // 
            this.pContainer4.Location = new System.Drawing.Point(598, 381);
            this.pContainer4.Name = "pContainer4";
            this.pContainer4.Size = new System.Drawing.Size(580, 217);
            this.pContainer4.TabIndex = 12;
            // 
            // timer3
            // 
            this.timer3.Interval = 2000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 2000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 610);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pContainer4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pContainer3);
            this.Controls.Add(this.btnTimer2Stop);
            this.Controls.Add(this.btnTimer1Stop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pContainer2);
            this.Controls.Add(this.btnTimer2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimerTab1);
            this.Controls.Add(this.pContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Button btnTimerTab1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimer2;
        private System.Windows.Forms.Panel pContainer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnTimer1Stop;
        private System.Windows.Forms.Button btnTimer2Stop;
        private System.Windows.Forms.Panel pContainer3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pContainer4;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

