
namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.M_identifier_lab = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tapage2 = new System.Windows.Forms.TabPage();
            this.history_Rtbx = new System.Windows.Forms.RichTextBox();
            this.history_Del_Ptx = new System.Windows.Forms.PictureBox();
            this.tapage1 = new System.Windows.Forms.TabPage();
            this.data_clear_ptx = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.history_tbx = new System.Windows.Forms.TextBox();
            this.outcome_tbx = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_control = new System.Windows.Forms.Panel();
            this.memory_read_btn = new System.Windows.Forms.Button();
            this.memory_clear_btn = new System.Windows.Forms.Button();
            this.num0_btn = new System.Windows.Forms.Button();
            this.memory_subtract_btn = new System.Windows.Forms.Button();
            this.square_Btn = new System.Windows.Forms.Button();
            this.memory_add_btn = new System.Windows.Forms.Button();
            this.num8_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.num5_btn = new System.Windows.Forms.Button();
            this.num1_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.num2_btn = new System.Windows.Forms.Button();
            this.memory_save_btn = new System.Windows.Forms.Button();
            this.num4_btn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.num9_btn = new System.Windows.Forms.Button();
            this.percent_Btn = new System.Windows.Forms.Button();
            this.reciprocal_btn = new System.Windows.Forms.Button();
            this.equal_btn = new System.Windows.Forms.Button();
            this.dot_Btn = new System.Windows.Forms.Button();
            this.clean_Outcome_Btn = new System.Windows.Forms.Button();
            this.num_ChangeBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.squared_Btn = new System.Windows.Forms.Button();
            this.clean_btn = new System.Windows.Forms.Button();
            this.num7_btn = new System.Windows.Forms.Button();
            this.num3_btn = new System.Windows.Forms.Button();
            this.num6_btn = new System.Windows.Forms.Button();
            this.del_Btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tapage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.history_Del_Ptx)).BeginInit();
            this.tapage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_clear_ptx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.M_identifier_lab);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.history_tbx);
            this.panel1.Controls.Add(this.outcome_tbx);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 600);
            this.panel1.TabIndex = 0;
            // 
            // M_identifier_lab
            // 
            this.M_identifier_lab.AutoSize = true;
            this.M_identifier_lab.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.M_identifier_lab.ForeColor = System.Drawing.SystemColors.Window;
            this.M_identifier_lab.Location = new System.Drawing.Point(10, 7);
            this.M_identifier_lab.Name = "M_identifier_lab";
            this.M_identifier_lab.Size = new System.Drawing.Size(32, 27);
            this.M_identifier_lab.TabIndex = 8;
            this.M_identifier_lab.Text = "M";
            this.M_identifier_lab.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tapage2);
            this.tabControl1.Controls.Add(this.tapage1);
            this.tabControl1.Location = new System.Drawing.Point(469, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(325, 533);
            this.tabControl1.TabIndex = 7;
            // 
            // tapage2
            // 
            this.tapage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.tapage2.Controls.Add(this.history_Rtbx);
            this.tapage2.Controls.Add(this.history_Del_Ptx);
            this.tapage2.Location = new System.Drawing.Point(4, 29);
            this.tapage2.Name = "tapage2";
            this.tapage2.Padding = new System.Windows.Forms.Padding(3);
            this.tapage2.Size = new System.Drawing.Size(317, 500);
            this.tapage2.TabIndex = 1;
            this.tapage2.Text = "历史记录";
            // 
            // history_Rtbx
            // 
            this.history_Rtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.history_Rtbx.ForeColor = System.Drawing.SystemColors.Window;
            this.history_Rtbx.Location = new System.Drawing.Point(0, 0);
            this.history_Rtbx.Name = "history_Rtbx";
            this.history_Rtbx.Size = new System.Drawing.Size(317, 448);
            this.history_Rtbx.TabIndex = 6;
            this.history_Rtbx.Text = "";
            // 
            // history_Del_Ptx
            // 
            this.history_Del_Ptx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.history_Del_Ptx.Image = ((System.Drawing.Image)(resources.GetObject("history_Del_Ptx.Image")));
            this.history_Del_Ptx.Location = new System.Drawing.Point(258, 454);
            this.history_Del_Ptx.Name = "history_Del_Ptx";
            this.history_Del_Ptx.Size = new System.Drawing.Size(55, 40);
            this.history_Del_Ptx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.history_Del_Ptx.TabIndex = 5;
            this.history_Del_Ptx.TabStop = false;
            this.history_Del_Ptx.Click += new System.EventHandler(this.History_Del_Ptx_Click);
            // 
            // tapage1
            // 
            this.tapage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.tapage1.Controls.Add(this.data_clear_ptx);
            this.tapage1.Controls.Add(this.dataGridView1);
            this.tapage1.Location = new System.Drawing.Point(4, 29);
            this.tapage1.Name = "tapage1";
            this.tapage1.Padding = new System.Windows.Forms.Padding(3);
            this.tapage1.Size = new System.Drawing.Size(317, 500);
            this.tapage1.TabIndex = 0;
            this.tapage1.Text = "记忆";
            // 
            // data_clear_ptx
            // 
            this.data_clear_ptx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.data_clear_ptx.Image = ((System.Drawing.Image)(resources.GetObject("data_clear_ptx.Image")));
            this.data_clear_ptx.Location = new System.Drawing.Point(256, 454);
            this.data_clear_ptx.Name = "data_clear_ptx";
            this.data_clear_ptx.Size = new System.Drawing.Size(55, 40);
            this.data_clear_ptx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.data_clear_ptx.TabIndex = 6;
            this.data_clear_ptx.TabStop = false;
            this.data_clear_ptx.Click += new System.EventHandler(this.Data_Clear_Ptx_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-6, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(327, 448);
            this.dataGridView1.TabIndex = 5;
            // 
            // history_tbx
            // 
            this.history_tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.history_tbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.history_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.history_tbx.ForeColor = System.Drawing.SystemColors.Window;
            this.history_tbx.Location = new System.Drawing.Point(10, 53);
            this.history_tbx.Multiline = true;
            this.history_tbx.Name = "history_tbx";
            this.history_tbx.Size = new System.Drawing.Size(429, 68);
            this.history_tbx.TabIndex = 6;
            this.history_tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // outcome_tbx
            // 
            this.outcome_tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outcome_tbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.outcome_tbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outcome_tbx.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outcome_tbx.ForeColor = System.Drawing.SystemColors.Window;
            this.outcome_tbx.Location = new System.Drawing.Point(10, 127);
            this.outcome_tbx.Multiline = true;
            this.outcome_tbx.Name = "outcome_tbx";
            this.outcome_tbx.Size = new System.Drawing.Size(429, 68);
            this.outcome_tbx.TabIndex = 5;
            this.outcome_tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel_control);
            this.panel2.Controls.Add(this.num0_btn);
            this.panel2.Controls.Add(this.memory_subtract_btn);
            this.panel2.Controls.Add(this.square_Btn);
            this.panel2.Controls.Add(this.memory_add_btn);
            this.panel2.Controls.Add(this.num8_btn);
            this.panel2.Controls.Add(this.add_btn);
            this.panel2.Controls.Add(this.num5_btn);
            this.panel2.Controls.Add(this.num1_btn);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.num2_btn);
            this.panel2.Controls.Add(this.memory_save_btn);
            this.panel2.Controls.Add(this.num4_btn);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.num9_btn);
            this.panel2.Controls.Add(this.percent_Btn);
            this.panel2.Controls.Add(this.reciprocal_btn);
            this.panel2.Controls.Add(this.equal_btn);
            this.panel2.Controls.Add(this.dot_Btn);
            this.panel2.Controls.Add(this.clean_Outcome_Btn);
            this.panel2.Controls.Add(this.num_ChangeBtn);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.squared_Btn);
            this.panel2.Controls.Add(this.clean_btn);
            this.panel2.Controls.Add(this.num7_btn);
            this.panel2.Controls.Add(this.num3_btn);
            this.panel2.Controls.Add(this.num6_btn);
            this.panel2.Controls.Add(this.del_Btn);
            this.panel2.Location = new System.Drawing.Point(-2, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 396);
            this.panel2.TabIndex = 4;
            // 
            // panel_control
            // 
            this.panel_control.Controls.Add(this.memory_read_btn);
            this.panel_control.Controls.Add(this.memory_clear_btn);
            this.panel_control.Location = new System.Drawing.Point(5, 3);
            this.panel_control.Name = "panel_control";
            this.panel_control.Size = new System.Drawing.Size(192, 48);
            this.panel_control.TabIndex = 35;
            // 
            // memory_read_btn
            // 
            this.memory_read_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.memory_read_btn.FlatAppearance.BorderSize = 0;
            this.memory_read_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memory_read_btn.ForeColor = System.Drawing.Color.White;
            this.memory_read_btn.Location = new System.Drawing.Point(88, 18);
            this.memory_read_btn.Name = "memory_read_btn";
            this.memory_read_btn.Size = new System.Drawing.Size(78, 30);
            this.memory_read_btn.TabIndex = 34;
            this.memory_read_btn.Text = "MR";
            this.memory_read_btn.UseVisualStyleBackColor = false;
            this.memory_read_btn.Click += new System.EventHandler(this.Memory_Read_Btn_Click);
            // 
            // memory_clear_btn
            // 
            this.memory_clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.memory_clear_btn.FlatAppearance.BorderSize = 0;
            this.memory_clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memory_clear_btn.ForeColor = System.Drawing.Color.White;
            this.memory_clear_btn.Location = new System.Drawing.Point(0, 18);
            this.memory_clear_btn.Name = "memory_clear_btn";
            this.memory_clear_btn.Size = new System.Drawing.Size(78, 30);
            this.memory_clear_btn.TabIndex = 31;
            this.memory_clear_btn.Text = "MC";
            this.memory_clear_btn.UseVisualStyleBackColor = false;
            this.memory_clear_btn.Click += new System.EventHandler(this.Memory_Clear_Btn_Click);
            // 
            // num0_btn
            // 
            this.num0_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.num0_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num0_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num0_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.num0_btn.Location = new System.Drawing.Point(111, 337);
            this.num0_btn.Name = "num0_btn";
            this.num0_btn.Size = new System.Drawing.Size(100, 50);
            this.num0_btn.TabIndex = 15;
            this.num0_btn.Text = "0";
            this.num0_btn.UseVisualStyleBackColor = false;
            this.num0_btn.Click += new System.EventHandler(this.Number_Click);
            // 
            // memory_subtract_btn
            // 
            this.memory_subtract_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.memory_subtract_btn.FlatAppearance.BorderSize = 0;
            this.memory_subtract_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memory_subtract_btn.ForeColor = System.Drawing.Color.White;
            this.memory_subtract_btn.Location = new System.Drawing.Point(261, 21);
            this.memory_subtract_btn.Name = "memory_subtract_btn";
            this.memory_subtract_btn.Size = new System.Drawing.Size(78, 30);
            this.memory_subtract_btn.TabIndex = 33;
            this.memory_subtract_btn.Text = "M-";
            this.memory_subtract_btn.UseVisualStyleBackColor = false;
            this.memory_subtract_btn.Click += new System.EventHandler(this.Memory_Subtract_Btn_Click);
            // 
            // square_Btn
            // 
            this.square_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.square_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.square_Btn.ForeColor = System.Drawing.SystemColors.Window;
            this.square_Btn.Location = new System.Drawing.Point(111, 113);
            this.square_Btn.Name = "square_Btn";
            this.square_Btn.Size = new System.Drawing.Size(100, 50);
            this.square_Btn.TabIndex = 14;
            this.square_Btn.Text = "x²";
            this.square_Btn.UseVisualStyleBackColor = false;
            this.square_Btn.Click += new System.EventHandler(this.Square_Btn_Click);
            // 
            // memory_add_btn
            // 
            this.memory_add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.memory_add_btn.FlatAppearance.BorderSize = 0;
            this.memory_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memory_add_btn.ForeColor = System.Drawing.Color.White;
            this.memory_add_btn.Location = new System.Drawing.Point(177, 21);
            this.memory_add_btn.Name = "memory_add_btn";
            this.memory_add_btn.Size = new System.Drawing.Size(78, 30);
            this.memory_add_btn.TabIndex = 32;
            this.memory_add_btn.Text = "M+";
            this.memory_add_btn.UseVisualStyleBackColor = false;
            this.memory_add_btn.Click += new System.EventHandler(this.Memory_Add_Btn_Click);
            // 
            // num8_btn
            // 
            this.num8_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.num8_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num8_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num8_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.num8_btn.Location = new System.Drawing.Point(111, 169);
            this.num8_btn.Name = "num8_btn";
            this.num8_btn.Size = new System.Drawing.Size(100, 50);
            this.num8_btn.TabIndex = 16;
            this.num8_btn.Text = "8";
            this.num8_btn.UseVisualStyleBackColor = false;
            this.num8_btn.Click += new System.EventHandler(this.Number_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.add_btn.Location = new System.Drawing.Point(323, 281);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(100, 50);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "+";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.Operator_Click);
            // 
            // num5_btn
            // 
            this.num5_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.num5_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num5_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num5_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.num5_btn.Location = new System.Drawing.Point(111, 225);
            this.num5_btn.Name = "num5_btn";
            this.num5_btn.Size = new System.Drawing.Size(100, 50);
            this.num5_btn.TabIndex = 13;
            this.num5_btn.Text = "5";
            this.num5_btn.UseVisualStyleBackColor = false;
            this.num5_btn.Click += new System.EventHandler(this.Number_Click);
            // 
            // num1_btn
            // 
            this.num1_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.num1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num1_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num1_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.num1_btn.Location = new System.Drawing.Point(5, 281);
            this.num1_btn.Name = "num1_btn";
            this.num1_btn.Size = new System.Drawing.Size(100, 50);
            this.num1_btn.TabIndex = 17;
            this.num1_btn.Text = "1";
            this.num1_btn.UseVisualStyleBackColor = false;
            this.num1_btn.Click += new System.EventHandler(this.Number_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(323, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Operator_Click);
            // 
            // num2_btn
            // 
            this.num2_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.num2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num2_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num2_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.num2_btn.Location = new System.Drawing.Point(111, 281);
            this.num2_btn.Name = "num2_btn";
            this.num2_btn.Size = new System.Drawing.Size(100, 50);
            this.num2_btn.TabIndex = 12;
            this.num2_btn.Text = "2";
            this.num2_btn.UseVisualStyleBackColor = false;
            this.num2_btn.Click += new System.EventHandler(this.Number_Click);
            // 
            // memory_save_btn
            // 
            this.memory_save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.memory_save_btn.FlatAppearance.BorderSize = 0;
            this.memory_save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memory_save_btn.ForeColor = System.Drawing.Color.White;
            this.memory_save_btn.Location = new System.Drawing.Point(345, 21);
            this.memory_save_btn.Name = "memory_save_btn";
            this.memory_save_btn.Size = new System.Drawing.Size(78, 30);
            this.memory_save_btn.TabIndex = 30;
            this.memory_save_btn.Text = "MS";
            this.memory_save_btn.UseVisualStyleBackColor = false;
            this.memory_save_btn.Click += new System.EventHandler(this.Memory_Save_Btn_Click);
            // 
            // num4_btn
            // 
            this.num4_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.num4_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num4_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num4_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.num4_btn.Location = new System.Drawing.Point(5, 225);
            this.num4_btn.Name = "num4_btn";
            this.num4_btn.Size = new System.Drawing.Size(100, 50);
            this.num4_btn.TabIndex = 18;
            this.num4_btn.Text = "4";
            this.num4_btn.UseVisualStyleBackColor = false;
            this.num4_btn.Click += new System.EventHandler(this.Number_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.Window;
            this.button5.Location = new System.Drawing.Point(323, 113);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 50);
            this.button5.TabIndex = 4;
            this.button5.Text = "÷";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Operator_Click);
            // 
            // num9_btn
            // 
            this.num9_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.num9_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num9_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num9_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.num9_btn.Location = new System.Drawing.Point(217, 169);
            this.num9_btn.Name = "num9_btn";
            this.num9_btn.Size = new System.Drawing.Size(100, 50);
            this.num9_btn.TabIndex = 11;
            this.num9_btn.Text = "9";
            this.num9_btn.UseVisualStyleBackColor = false;
            this.num9_btn.Click += new System.EventHandler(this.Number_Click);
            // 
            // percent_Btn
            // 
            this.percent_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.percent_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.percent_Btn.ForeColor = System.Drawing.SystemColors.Window;
            this.percent_Btn.Location = new System.Drawing.Point(5, 57);
            this.percent_Btn.Name = "percent_Btn";
            this.percent_Btn.Size = new System.Drawing.Size(100, 50);
            this.percent_Btn.TabIndex = 25;
            this.percent_Btn.Text = "%";
            this.percent_Btn.UseVisualStyleBackColor = false;
            this.percent_Btn.Click += new System.EventHandler(this.Percent_Btn_Click);
            // 
            // reciprocal_btn
            // 
            this.reciprocal_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.reciprocal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reciprocal_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.reciprocal_btn.Location = new System.Drawing.Point(5, 113);
            this.reciprocal_btn.Name = "reciprocal_btn";
            this.reciprocal_btn.Size = new System.Drawing.Size(100, 50);
            this.reciprocal_btn.TabIndex = 19;
            this.reciprocal_btn.Text = "1/x";
            this.reciprocal_btn.UseVisualStyleBackColor = false;
            this.reciprocal_btn.Click += new System.EventHandler(this.Reciprocal_Btn_Click);
            // 
            // equal_btn
            // 
            this.equal_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.equal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equal_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equal_btn.Location = new System.Drawing.Point(323, 337);
            this.equal_btn.Name = "equal_btn";
            this.equal_btn.Size = new System.Drawing.Size(100, 50);
            this.equal_btn.TabIndex = 5;
            this.equal_btn.Text = "=";
            this.equal_btn.UseVisualStyleBackColor = false;
            this.equal_btn.Click += new System.EventHandler(this.Equal_Btn_Click);
            // 
            // dot_Btn
            // 
            this.dot_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.dot_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dot_Btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dot_Btn.ForeColor = System.Drawing.SystemColors.Window;
            this.dot_Btn.Location = new System.Drawing.Point(217, 337);
            this.dot_Btn.Name = "dot_Btn";
            this.dot_Btn.Size = new System.Drawing.Size(100, 50);
            this.dot_Btn.TabIndex = 10;
            this.dot_Btn.Text = ".";
            this.dot_Btn.UseVisualStyleBackColor = false;
            this.dot_Btn.Click += new System.EventHandler(this.Dot_Btn_Click);
            // 
            // clean_Outcome_Btn
            // 
            this.clean_Outcome_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.clean_Outcome_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clean_Outcome_Btn.ForeColor = System.Drawing.SystemColors.Window;
            this.clean_Outcome_Btn.Location = new System.Drawing.Point(111, 57);
            this.clean_Outcome_Btn.Name = "clean_Outcome_Btn";
            this.clean_Outcome_Btn.Size = new System.Drawing.Size(100, 50);
            this.clean_Outcome_Btn.TabIndex = 24;
            this.clean_Outcome_Btn.Text = "CE";
            this.clean_Outcome_Btn.UseVisualStyleBackColor = false;
            this.clean_Outcome_Btn.Click += new System.EventHandler(this.Clean_Outcome_Btn_Click);
            // 
            // num_ChangeBtn
            // 
            this.num_ChangeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.num_ChangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num_ChangeBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num_ChangeBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.num_ChangeBtn.Location = new System.Drawing.Point(5, 337);
            this.num_ChangeBtn.Name = "num_ChangeBtn";
            this.num_ChangeBtn.Size = new System.Drawing.Size(100, 50);
            this.num_ChangeBtn.TabIndex = 20;
            this.num_ChangeBtn.Text = "+/-";
            this.num_ChangeBtn.UseVisualStyleBackColor = false;
            this.num_ChangeBtn.Click += new System.EventHandler(this.Num_Change_Btn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(323, 169);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 50);
            this.button4.TabIndex = 6;
            this.button4.Text = "× ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Operator_Click);
            // 
            // squared_Btn
            // 
            this.squared_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.squared_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.squared_Btn.ForeColor = System.Drawing.SystemColors.Window;
            this.squared_Btn.Location = new System.Drawing.Point(217, 113);
            this.squared_Btn.Name = "squared_Btn";
            this.squared_Btn.Size = new System.Drawing.Size(100, 50);
            this.squared_Btn.TabIndex = 9;
            this.squared_Btn.Text = "²√x";
            this.squared_Btn.UseVisualStyleBackColor = false;
            this.squared_Btn.Click += new System.EventHandler(this.Squared_Btn_Click);
            // 
            // clean_btn
            // 
            this.clean_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.clean_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clean_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.clean_btn.Location = new System.Drawing.Point(217, 57);
            this.clean_btn.Name = "clean_btn";
            this.clean_btn.Size = new System.Drawing.Size(100, 50);
            this.clean_btn.TabIndex = 23;
            this.clean_btn.Text = "C";
            this.clean_btn.UseVisualStyleBackColor = false;
            this.clean_btn.Click += new System.EventHandler(this.CleanBtn_Click);
            // 
            // num7_btn
            // 
            this.num7_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.num7_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num7_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num7_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.num7_btn.Location = new System.Drawing.Point(5, 169);
            this.num7_btn.Name = "num7_btn";
            this.num7_btn.Size = new System.Drawing.Size(100, 50);
            this.num7_btn.TabIndex = 21;
            this.num7_btn.Text = "7";
            this.num7_btn.UseVisualStyleBackColor = false;
            this.num7_btn.Click += new System.EventHandler(this.Number_Click);
            // 
            // num3_btn
            // 
            this.num3_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.num3_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num3_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num3_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.num3_btn.Location = new System.Drawing.Point(217, 281);
            this.num3_btn.Name = "num3_btn";
            this.num3_btn.Size = new System.Drawing.Size(100, 50);
            this.num3_btn.TabIndex = 7;
            this.num3_btn.Text = "3";
            this.num3_btn.UseVisualStyleBackColor = false;
            this.num3_btn.Click += new System.EventHandler(this.Number_Click);
            // 
            // num6_btn
            // 
            this.num6_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.num6_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num6_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num6_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.num6_btn.Location = new System.Drawing.Point(217, 225);
            this.num6_btn.Name = "num6_btn";
            this.num6_btn.Size = new System.Drawing.Size(100, 50);
            this.num6_btn.TabIndex = 8;
            this.num6_btn.Text = "6";
            this.num6_btn.UseVisualStyleBackColor = false;
            this.num6_btn.Click += new System.EventHandler(this.Number_Click);
            // 
            // del_Btn
            // 
            this.del_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.del_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.del_Btn.ForeColor = System.Drawing.SystemColors.Window;
            this.del_Btn.Location = new System.Drawing.Point(323, 57);
            this.del_Btn.Name = "del_Btn";
            this.del_Btn.Size = new System.Drawing.Size(100, 50);
            this.del_Btn.TabIndex = 22;
            this.del_Btn.Text = "❎";
            this.del_Btn.UseVisualStyleBackColor = false;
            this.del_Btn.Click += new System.EventHandler(this.Del_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(799, 602);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "计算机";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InitialForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tapage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.history_Del_Ptx)).EndInit();
            this.tapage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_clear_ptx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel_control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tapage2;
        private System.Windows.Forms.RichTextBox history_Rtbx;
        private System.Windows.Forms.PictureBox history_Del_Ptx;
        private System.Windows.Forms.TabPage tapage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox history_tbx;
        private System.Windows.Forms.TextBox outcome_tbx;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button memory_read_btn;
        private System.Windows.Forms.Button num0_btn;
        private System.Windows.Forms.Button memory_subtract_btn;
        private System.Windows.Forms.Button square_Btn;
        private System.Windows.Forms.Button memory_add_btn;
        private System.Windows.Forms.Button num8_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button num5_btn;
        private System.Windows.Forms.Button memory_clear_btn;
        private System.Windows.Forms.Button num1_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button num2_btn;
        private System.Windows.Forms.Button memory_save_btn;
        private System.Windows.Forms.Button num4_btn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button num9_btn;
        private System.Windows.Forms.Button percent_Btn;
        private System.Windows.Forms.Button reciprocal_btn;
        private System.Windows.Forms.Button equal_btn;
        private System.Windows.Forms.Button dot_Btn;
        private System.Windows.Forms.Button clean_Outcome_Btn;
        private System.Windows.Forms.Button num_ChangeBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button squared_Btn;
        private System.Windows.Forms.Button clean_btn;
        private System.Windows.Forms.Button num7_btn;
        private System.Windows.Forms.Button num3_btn;
        private System.Windows.Forms.Button num6_btn;
        private System.Windows.Forms.Button del_Btn;
        private System.Windows.Forms.Label M_identifier_lab;
        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.PictureBox data_clear_ptx;
    }
}

