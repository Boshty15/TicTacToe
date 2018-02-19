namespace tictacRom
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbt_igraprotiosebi = new System.Windows.Forms.RadioButton();
            this.btn_ustaviserver = new System.Windows.Forms.Button();
            this.btn_zazeniserver = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_pridruziseigri = new System.Windows.Forms.Button();
            this.btn_zapritrenutnoigro = new System.Windows.Forms.Button();
            this.btn_novaigra = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbt_1_1 = new System.Windows.Forms.Button();
            this.pbt_1_2 = new System.Windows.Forms.Button();
            this.pbt_1_3 = new System.Windows.Forms.Button();
            this.pbt_2_1 = new System.Windows.Forms.Button();
            this.pbt_2_2 = new System.Windows.Forms.Button();
            this.pbt_2_3 = new System.Windows.Forms.Button();
            this.pbt_3_1 = new System.Windows.Forms.Button();
            this.pbt_3_2 = new System.Windows.Forms.Button();
            this.pbt_3_3 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slbl_povezava = new System.Windows.Forms.ToolStripStatusLabel();
            this.slbl_ip = new System.Windows.Forms.ToolStripStatusLabel();
            this.slbl_port = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtxt_history = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_port);
            this.groupBox1.Controls.Add(this.txt_ip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(516, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP in PORT";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(68, 63);
            this.txt_port.Margin = new System.Windows.Forms.Padding(4);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(189, 22);
            this.txt_port.TabIndex = 3;
            this.txt_port.Text = "3154";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(68, 31);
            this.txt_ip.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(189, 22);
            this.txt_ip.TabIndex = 2;
            this.txt_ip.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "PORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbt_igraprotiosebi);
            this.groupBox2.Controls.Add(this.btn_ustaviserver);
            this.groupBox2.Controls.Add(this.btn_zazeniserver);
            this.groupBox2.Location = new System.Drawing.Point(31, 93);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(463, 102);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SERVER";
            // 
            // rbt_igraprotiosebi
            // 
            this.rbt_igraprotiosebi.AutoSize = true;
            this.rbt_igraprotiosebi.Checked = true;
            this.rbt_igraprotiosebi.Location = new System.Drawing.Point(24, 31);
            this.rbt_igraprotiosebi.Margin = new System.Windows.Forms.Padding(4);
            this.rbt_igraprotiosebi.Name = "rbt_igraprotiosebi";
            this.rbt_igraprotiosebi.Size = new System.Drawing.Size(123, 21);
            this.rbt_igraprotiosebi.TabIndex = 6;
            this.rbt_igraprotiosebi.TabStop = true;
            this.rbt_igraprotiosebi.Text = "igra proti osebi";
            this.rbt_igraprotiosebi.UseVisualStyleBackColor = true;
            // 
            // btn_ustaviserver
            // 
            this.btn_ustaviserver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_ustaviserver.Enabled = false;
            this.btn_ustaviserver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ustaviserver.Location = new System.Drawing.Point(247, 63);
            this.btn_ustaviserver.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ustaviserver.Name = "btn_ustaviserver";
            this.btn_ustaviserver.Size = new System.Drawing.Size(199, 28);
            this.btn_ustaviserver.TabIndex = 5;
            this.btn_ustaviserver.Text = "Ustavi server";
            this.btn_ustaviserver.UseVisualStyleBackColor = false;
            this.btn_ustaviserver.Click += new System.EventHandler(this.btn_ustaviserver_Click);
            // 
            // btn_zazeniserver
            // 
            this.btn_zazeniserver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_zazeniserver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zazeniserver.Location = new System.Drawing.Point(247, 27);
            this.btn_zazeniserver.Margin = new System.Windows.Forms.Padding(4);
            this.btn_zazeniserver.Name = "btn_zazeniserver";
            this.btn_zazeniserver.Size = new System.Drawing.Size(199, 28);
            this.btn_zazeniserver.TabIndex = 4;
            this.btn_zazeniserver.Text = "Zaženi server";
            this.btn_zazeniserver.UseVisualStyleBackColor = false;
            this.btn_zazeniserver.Click += new System.EventHandler(this.btn_zazeniserver_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_pridruziseigri);
            this.groupBox3.Controls.Add(this.btn_zapritrenutnoigro);
            this.groupBox3.Location = new System.Drawing.Point(31, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(463, 69);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ODJEMALEC";
            // 
            // btn_pridruziseigri
            // 
            this.btn_pridruziseigri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_pridruziseigri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pridruziseigri.Location = new System.Drawing.Point(24, 27);
            this.btn_pridruziseigri.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pridruziseigri.Name = "btn_pridruziseigri";
            this.btn_pridruziseigri.Size = new System.Drawing.Size(191, 28);
            this.btn_pridruziseigri.TabIndex = 5;
            this.btn_pridruziseigri.Text = "Pridruži se igri";
            this.btn_pridruziseigri.UseVisualStyleBackColor = false;
            this.btn_pridruziseigri.Click += new System.EventHandler(this.btn_pridruziseigri_Click);
            // 
            // btn_zapritrenutnoigro
            // 
            this.btn_zapritrenutnoigro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_zapritrenutnoigro.Enabled = false;
            this.btn_zapritrenutnoigro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zapritrenutnoigro.Location = new System.Drawing.Point(247, 27);
            this.btn_zapritrenutnoigro.Margin = new System.Windows.Forms.Padding(4);
            this.btn_zapritrenutnoigro.Name = "btn_zapritrenutnoigro";
            this.btn_zapritrenutnoigro.Size = new System.Drawing.Size(199, 28);
            this.btn_zapritrenutnoigro.TabIndex = 4;
            this.btn_zapritrenutnoigro.Text = "Zapusti trenutno igro";
            this.btn_zapritrenutnoigro.UseVisualStyleBackColor = false;
            this.btn_zapritrenutnoigro.Click += new System.EventHandler(this.btn_zapritrenutnoigro_Click);
            // 
            // btn_novaigra
            // 
            this.btn_novaigra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_novaigra.Enabled = false;
            this.btn_novaigra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novaigra.Location = new System.Drawing.Point(506, 123);
            this.btn_novaigra.Margin = new System.Windows.Forms.Padding(4);
            this.btn_novaigra.Name = "btn_novaigra";
            this.btn_novaigra.Size = new System.Drawing.Size(267, 69);
            this.btn_novaigra.TabIndex = 3;
            this.btn_novaigra.Text = "NOVA IGRA";
            this.btn_novaigra.UseVisualStyleBackColor = false;
            this.btn_novaigra.Click += new System.EventHandler(this.btn_novaigra_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pbt_1_1);
            this.flowLayoutPanel1.Controls.Add(this.pbt_1_2);
            this.flowLayoutPanel1.Controls.Add(this.pbt_1_3);
            this.flowLayoutPanel1.Controls.Add(this.pbt_2_1);
            this.flowLayoutPanel1.Controls.Add(this.pbt_2_2);
            this.flowLayoutPanel1.Controls.Add(this.pbt_2_3);
            this.flowLayoutPanel1.Controls.Add(this.pbt_3_1);
            this.flowLayoutPanel1.Controls.Add(this.pbt_3_2);
            this.flowLayoutPanel1.Controls.Add(this.pbt_3_3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(462, 203);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(331, 300);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // pbt_1_1
            // 
            this.pbt_1_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbt_1_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbt_1_1.Location = new System.Drawing.Point(0, 0);
            this.pbt_1_1.Margin = new System.Windows.Forms.Padding(0);
            this.pbt_1_1.Name = "pbt_1_1";
            this.pbt_1_1.Size = new System.Drawing.Size(107, 98);
            this.pbt_1_1.TabIndex = 0;
            this.pbt_1_1.UseVisualStyleBackColor = false;
            this.pbt_1_1.Click += new System.EventHandler(this.pbt_1_1_Click);
            // 
            // pbt_1_2
            // 
            this.pbt_1_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbt_1_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbt_1_2.Location = new System.Drawing.Point(107, 0);
            this.pbt_1_2.Margin = new System.Windows.Forms.Padding(0);
            this.pbt_1_2.Name = "pbt_1_2";
            this.pbt_1_2.Size = new System.Drawing.Size(107, 98);
            this.pbt_1_2.TabIndex = 1;
            this.pbt_1_2.UseVisualStyleBackColor = false;
            // 
            // pbt_1_3
            // 
            this.pbt_1_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbt_1_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbt_1_3.Location = new System.Drawing.Point(214, 0);
            this.pbt_1_3.Margin = new System.Windows.Forms.Padding(0);
            this.pbt_1_3.Name = "pbt_1_3";
            this.pbt_1_3.Size = new System.Drawing.Size(107, 98);
            this.pbt_1_3.TabIndex = 2;
            this.pbt_1_3.UseVisualStyleBackColor = false;
            // 
            // pbt_2_1
            // 
            this.pbt_2_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbt_2_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbt_2_1.Location = new System.Drawing.Point(0, 98);
            this.pbt_2_1.Margin = new System.Windows.Forms.Padding(0);
            this.pbt_2_1.Name = "pbt_2_1";
            this.pbt_2_1.Size = new System.Drawing.Size(107, 98);
            this.pbt_2_1.TabIndex = 3;
            this.pbt_2_1.UseVisualStyleBackColor = false;
            // 
            // pbt_2_2
            // 
            this.pbt_2_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbt_2_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbt_2_2.Location = new System.Drawing.Point(107, 98);
            this.pbt_2_2.Margin = new System.Windows.Forms.Padding(0);
            this.pbt_2_2.Name = "pbt_2_2";
            this.pbt_2_2.Size = new System.Drawing.Size(107, 98);
            this.pbt_2_2.TabIndex = 4;
            this.pbt_2_2.UseVisualStyleBackColor = false;
            // 
            // pbt_2_3
            // 
            this.pbt_2_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbt_2_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbt_2_3.Location = new System.Drawing.Point(214, 98);
            this.pbt_2_3.Margin = new System.Windows.Forms.Padding(0);
            this.pbt_2_3.Name = "pbt_2_3";
            this.pbt_2_3.Size = new System.Drawing.Size(107, 98);
            this.pbt_2_3.TabIndex = 5;
            this.pbt_2_3.UseVisualStyleBackColor = false;
            // 
            // pbt_3_1
            // 
            this.pbt_3_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbt_3_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbt_3_1.Location = new System.Drawing.Point(0, 196);
            this.pbt_3_1.Margin = new System.Windows.Forms.Padding(0);
            this.pbt_3_1.Name = "pbt_3_1";
            this.pbt_3_1.Size = new System.Drawing.Size(107, 98);
            this.pbt_3_1.TabIndex = 6;
            this.pbt_3_1.UseVisualStyleBackColor = false;
            // 
            // pbt_3_2
            // 
            this.pbt_3_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbt_3_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbt_3_2.Location = new System.Drawing.Point(107, 196);
            this.pbt_3_2.Margin = new System.Windows.Forms.Padding(0);
            this.pbt_3_2.Name = "pbt_3_2";
            this.pbt_3_2.Size = new System.Drawing.Size(107, 98);
            this.pbt_3_2.TabIndex = 7;
            this.pbt_3_2.UseVisualStyleBackColor = false;
            // 
            // pbt_3_3
            // 
            this.pbt_3_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbt_3_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbt_3_3.Location = new System.Drawing.Point(214, 196);
            this.pbt_3_3.Margin = new System.Windows.Forms.Padding(0);
            this.pbt_3_3.Name = "pbt_3_3";
            this.pbt_3_3.Size = new System.Drawing.Size(107, 98);
            this.pbt_3_3.TabIndex = 8;
            this.pbt_3_3.UseVisualStyleBackColor = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Red;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slbl_povezava,
            this.slbl_ip,
            this.slbl_port});
            this.statusStrip1.Location = new System.Drawing.Point(0, 530);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(828, 25);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slbl_povezava
            // 
            this.slbl_povezava.Name = "slbl_povezava";
            this.slbl_povezava.Size = new System.Drawing.Size(95, 20);
            this.slbl_povezava.Text = "Ni povezave!";
            // 
            // slbl_ip
            // 
            this.slbl_ip.Name = "slbl_ip";
            this.slbl_ip.Size = new System.Drawing.Size(151, 20);
            this.slbl_ip.Text = "toolStripStatusLabel2";
            // 
            // slbl_port
            // 
            this.slbl_port.Name = "slbl_port";
            this.slbl_port.Size = new System.Drawing.Size(151, 20);
            this.slbl_port.Text = "toolStripStatusLabel3";
            // 
            // rtxt_history
            // 
            this.rtxt_history.Location = new System.Drawing.Point(31, 203);
            this.rtxt_history.Margin = new System.Windows.Forms.Padding(4);
            this.rtxt_history.Name = "rtxt_history";
            this.rtxt_history.ReadOnly = true;
            this.rtxt_history.Size = new System.Drawing.Size(378, 300);
            this.rtxt_history.TabIndex = 6;
            this.rtxt_history.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(828, 555);
            this.Controls.Add(this.rtxt_history);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_novaigra);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ustaviserver;
        private System.Windows.Forms.Button btn_zazeniserver;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_pridruziseigri;
        private System.Windows.Forms.Button btn_zapritrenutnoigro;
        private System.Windows.Forms.RadioButton rbt_igraprotiosebi;
        private System.Windows.Forms.Button btn_novaigra;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button pbt_1_1;
        private System.Windows.Forms.Button pbt_1_2;
        private System.Windows.Forms.Button pbt_1_3;
        private System.Windows.Forms.Button pbt_2_1;
        private System.Windows.Forms.Button pbt_2_2;
        private System.Windows.Forms.Button pbt_2_3;
        private System.Windows.Forms.Button pbt_3_1;
        private System.Windows.Forms.Button pbt_3_2;
        private System.Windows.Forms.Button pbt_3_3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slbl_povezava;
        private System.Windows.Forms.ToolStripStatusLabel slbl_port;
        private System.Windows.Forms.ToolStripStatusLabel slbl_ip;
        private System.Windows.Forms.RichTextBox rtxt_history;
    }
}

