namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            process1 = new System.Diagnostics.Process();
            button1 = new Button();
            button2 = new Button();
            listView2 = new ListView();
            listView1 = new ListView();
            listView3 = new ListView();
            listView4 = new ListView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(556, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listView2
            // 
            listView2.Location = new Point(12, 82);
            listView2.Name = "listView2";
            listView2.Size = new Size(151, 177);
            listView2.TabIndex = 4;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.SmallIcon;
            // 
            // listView1
            // 
            listView1.Location = new Point(169, 82);
            listView1.Name = "listView1";
            listView1.Size = new Size(151, 177);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.SmallIcon;
            // 
            // listView3
            // 
            listView3.Location = new Point(326, 82);
            listView3.Name = "listView3";
            listView3.Size = new Size(151, 177);
            listView3.TabIndex = 6;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.SmallIcon;
            listView3.SelectedIndexChanged += listView3_SelectedIndexChanged;
            // 
            // listView4
            // 
            listView4.Location = new Point(480, 82);
            listView4.Name = "listView4";
            listView4.Size = new Size(151, 177);
            listView4.TabIndex = 7;
            listView4.UseCompatibleStateImageBehavior = false;
            listView4.View = View.SmallIcon;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 64);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 8;
            label1.Text = "Випадаючий список";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 64);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 9;
            label2.Text = ".exe файли";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 64);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 10;
            label3.Text = "Всі процеси";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(518, 64);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 11;
            label4.Text = "Інформація";
            // 
            // button3
            // 
            button3.Location = new Point(290, 12);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 271);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView4);
            Controls.Add(listView3);
            Controls.Add(listView1);
            Controls.Add(listView2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Diagnostics.Process process1;
        private Button button1;
        private Button button2;
        private ListView listView2;
        private ListView listView1;
        private ListView listView3;
        private ListView listView4;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
    }
}