namespace AD_WEEK_3_RILL
{
    partial class main
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nama_tb = new System.Windows.Forms.TextBox();
            this.artis_tb = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.submit_butt = new System.Windows.Forms.Button();
            this.next_butt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "My favorite artist";
            // 
            // nama_tb
            // 
            this.nama_tb.Location = new System.Drawing.Point(241, 26);
            this.nama_tb.Name = "nama_tb";
            this.nama_tb.Size = new System.Drawing.Size(276, 31);
            this.nama_tb.TabIndex = 2;
            // 
            // artis_tb
            // 
            this.artis_tb.Location = new System.Drawing.Point(241, 82);
            this.artis_tb.Name = "artis_tb";
            this.artis_tb.Size = new System.Drawing.Size(276, 31);
            this.artis_tb.TabIndex = 3;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(241, 146);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(328, 29);
            this.checkBox.TabIndex = 4;
            this.checkBox.Text = "All of the content i put above is true!";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // submit_butt
            // 
            this.submit_butt.Location = new System.Drawing.Point(238, 207);
            this.submit_butt.Name = "submit_butt";
            this.submit_butt.Size = new System.Drawing.Size(112, 34);
            this.submit_butt.TabIndex = 5;
            this.submit_butt.Text = "Submit";
            this.submit_butt.UseVisualStyleBackColor = true;
            this.submit_butt.Click += new System.EventHandler(this.submit_butt_Click);
            // 
            // next_butt
            // 
            this.next_butt.Location = new System.Drawing.Point(261, 362);
            this.next_butt.Name = "next_butt";
            this.next_butt.Size = new System.Drawing.Size(159, 34);
            this.next_butt.TabIndex = 6;
            this.next_butt.Text = "Open next form";
            this.next_butt.UseVisualStyleBackColor = true;
            this.next_butt.Click += new System.EventHandler(this.next_butt_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.next_butt);
            this.Controls.Add(this.submit_butt);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.artis_tb);
            this.Controls.Add(this.nama_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "main";
            this.Text = "Main Window Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nama_tb;
        private TextBox artis_tb;
        private CheckBox checkBox;
        private Button submit_butt;
        private Button next_butt;
    }
}