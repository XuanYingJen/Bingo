namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl隨機號碼 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btn產生號碼 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn刪除所有號碼 = new System.Windows.Forms.Button();
            this.lbl筆數 = new System.Windows.Forms.Label();
            this.btn刪除所選號碼 = new System.Windows.Forms.Button();
            this.btn加入選號 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl提示字 = new System.Windows.Forms.Label();
            this.btn開獎結果查詢 = new System.Windows.Forms.Button();
            this.btn輸入號碼 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.btn包牌 = new System.Windows.Forms.Button();
            this.btn清除 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl累積得獎金額 = new System.Windows.Forms.Label();
            this.btn查詢歷史紀錄 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox包牌顯示 = new System.Windows.Forms.TextBox();
            this.textBox歷史紀錄 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl隨機號碼
            // 
            this.lbl隨機號碼.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl隨機號碼.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl隨機號碼.Location = new System.Drawing.Point(158, 36);
            this.lbl隨機號碼.Name = "lbl隨機號碼";
            this.lbl隨機號碼.Size = new System.Drawing.Size(127, 88);
            this.lbl隨機號碼.TabIndex = 0;
            this.lbl隨機號碼.Text = "00";
            this.lbl隨機號碼.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 31;
            this.listBox.Location = new System.Drawing.Point(17, 202);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(413, 128);
            this.listBox.TabIndex = 2;
            // 
            // btn產生號碼
            // 
            this.btn產生號碼.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn產生號碼.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn產生號碼.Location = new System.Drawing.Point(17, 140);
            this.btn產生號碼.Name = "btn產生號碼";
            this.btn產生號碼.Size = new System.Drawing.Size(198, 56);
            this.btn產生號碼.TabIndex = 3;
            this.btn產生號碼.Text = "產生號碼";
            this.btn產生號碼.UseVisualStyleBackColor = false;
            this.btn產生號碼.Click += new System.EventHandler(this.btn產生號碼_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.btn刪除所有號碼);
            this.groupBox1.Controls.Add(this.lbl筆數);
            this.groupBox1.Controls.Add(this.btn刪除所選號碼);
            this.groupBox1.Controls.Add(this.btn加入選號);
            this.groupBox1.Controls.Add(this.lbl隨機號碼);
            this.groupBox1.Controls.Add(this.listBox);
            this.groupBox1.Controls.Add(this.btn產生號碼);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(26, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 433);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Level 1";
            // 
            // btn刪除所有號碼
            // 
            this.btn刪除所有號碼.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn刪除所有號碼.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除所有號碼.ForeColor = System.Drawing.Color.Red;
            this.btn刪除所有號碼.Location = new System.Drawing.Point(232, 361);
            this.btn刪除所有號碼.Name = "btn刪除所有號碼";
            this.btn刪除所有號碼.Size = new System.Drawing.Size(198, 56);
            this.btn刪除所有號碼.TabIndex = 7;
            this.btn刪除所有號碼.Text = "刪除所有號碼";
            this.btn刪除所有號碼.UseVisualStyleBackColor = false;
            this.btn刪除所有號碼.Click += new System.EventHandler(this.btn刪除所有號碼_Click);
            // 
            // lbl筆數
            // 
            this.lbl筆數.AutoSize = true;
            this.lbl筆數.BackColor = System.Drawing.SystemColors.Info;
            this.lbl筆數.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl筆數.Location = new System.Drawing.Point(343, 314);
            this.lbl筆數.Name = "lbl筆數";
            this.lbl筆數.Size = new System.Drawing.Size(75, 30);
            this.lbl筆數.TabIndex = 4;
            this.lbl筆數.Text = "共0筆";
            // 
            // btn刪除所選號碼
            // 
            this.btn刪除所選號碼.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn刪除所選號碼.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除所選號碼.ForeColor = System.Drawing.Color.Blue;
            this.btn刪除所選號碼.Location = new System.Drawing.Point(17, 361);
            this.btn刪除所選號碼.Name = "btn刪除所選號碼";
            this.btn刪除所選號碼.Size = new System.Drawing.Size(198, 56);
            this.btn刪除所選號碼.TabIndex = 6;
            this.btn刪除所選號碼.Text = "刪除所選號碼";
            this.btn刪除所選號碼.UseVisualStyleBackColor = false;
            this.btn刪除所選號碼.Click += new System.EventHandler(this.btn刪除所選號碼_Click);
            // 
            // btn加入選號
            // 
            this.btn加入選號.BackColor = System.Drawing.Color.IndianRed;
            this.btn加入選號.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入選號.ForeColor = System.Drawing.Color.Black;
            this.btn加入選號.Location = new System.Drawing.Point(232, 140);
            this.btn加入選號.Name = "btn加入選號";
            this.btn加入選號.Size = new System.Drawing.Size(198, 56);
            this.btn加入選號.TabIndex = 5;
            this.btn加入選號.Text = "加入選號↓";
            this.btn加入選號.UseVisualStyleBackColor = false;
            this.btn加入選號.Click += new System.EventHandler(this.btn加入選號_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.lbl提示字);
            this.groupBox2.Controls.Add(this.btn開獎結果查詢);
            this.groupBox2.Controls.Add(this.btn輸入號碼);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(494, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(892, 433);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Level 2 and Level 3";
            // 
            // lbl提示字
            // 
            this.lbl提示字.BackColor = System.Drawing.SystemColors.Info;
            this.lbl提示字.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl提示字.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl提示字.Location = new System.Drawing.Point(21, 110);
            this.lbl提示字.Name = "lbl提示字";
            this.lbl提示字.Size = new System.Drawing.Size(330, 35);
            this.lbl提示字.TabIndex = 11;
            this.lbl提示字.Text = "(請用空格間隔每個數字)";
            // 
            // btn開獎結果查詢
            // 
            this.btn開獎結果查詢.BackColor = System.Drawing.Color.DarkOrange;
            this.btn開獎結果查詢.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn開獎結果查詢.Location = new System.Drawing.Point(21, 361);
            this.btn開獎結果查詢.Name = "btn開獎結果查詢";
            this.btn開獎結果查詢.Size = new System.Drawing.Size(849, 56);
            this.btn開獎結果查詢.TabIndex = 10;
            this.btn開獎結果查詢.Text = "~開獎結果查詢~";
            this.btn開獎結果查詢.UseVisualStyleBackColor = false;
            this.btn開獎結果查詢.Click += new System.EventHandler(this.btn開獎結果查詢_Click);
            // 
            // btn輸入號碼
            // 
            this.btn輸入號碼.BackColor = System.Drawing.SystemColors.Window;
            this.btn輸入號碼.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn輸入號碼.Location = new System.Drawing.Point(720, 49);
            this.btn輸入號碼.Name = "btn輸入號碼";
            this.btn輸入號碼.Size = new System.Drawing.Size(150, 56);
            this.btn輸入號碼.TabIndex = 8;
            this.btn輸入號碼.Text = "輸入號碼";
            this.btn輸入號碼.UseVisualStyleBackColor = false;
            this.btn輸入號碼.Click += new System.EventHandler(this.btn輸入號碼_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(21, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(674, 50);
            this.textBox1.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton1.Location = new System.Drawing.Point(26, 510);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "一星";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton2.Location = new System.Drawing.Point(146, 510);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "二星";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton3.Location = new System.Drawing.Point(267, 510);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 29);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "三星";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton4.Location = new System.Drawing.Point(379, 510);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(77, 29);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "四星";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton5.Location = new System.Drawing.Point(503, 510);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(77, 29);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "五星";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton6.Location = new System.Drawing.Point(26, 545);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(77, 29);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "六星";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton7.Location = new System.Drawing.Point(146, 545);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(77, 29);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "七星";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton8.Location = new System.Drawing.Point(267, 545);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(77, 29);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "八星";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton9.Location = new System.Drawing.Point(379, 545);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(77, 29);
            this.radioButton9.TabIndex = 8;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "九星";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton10.Location = new System.Drawing.Point(503, 545);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(77, 29);
            this.radioButton10.TabIndex = 9;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "十星";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // btn包牌
            // 
            this.btn包牌.BackColor = System.Drawing.Color.IndianRed;
            this.btn包牌.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn包牌.Location = new System.Drawing.Point(1037, 465);
            this.btn包牌.Name = "btn包牌";
            this.btn包牌.Size = new System.Drawing.Size(125, 56);
            this.btn包牌.TabIndex = 14;
            this.btn包牌.Text = "包 牌 !";
            this.btn包牌.UseVisualStyleBackColor = false;
            this.btn包牌.Click += new System.EventHandler(this.btn包牌_Click);
            // 
            // btn清除
            // 
            this.btn清除.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn清除.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除.Location = new System.Drawing.Point(1239, 465);
            this.btn清除.Name = "btn清除";
            this.btn清除.Size = new System.Drawing.Size(125, 55);
            this.btn清除.TabIndex = 95;
            this.btn清除.Text = "清除";
            this.btn清除.UseVisualStyleBackColor = false;
            this.btn清除.Click += new System.EventHandler(this.btn清除_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(873, 469);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 46);
            this.textBox2.TabIndex = 96;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(649, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 53);
            this.label2.TabIndex = 12;
            this.label2.Text = "請輸入張數：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox歷史紀錄);
            this.groupBox3.Controls.Add(this.lbl累積得獎金額);
            this.groupBox3.Controls.Add(this.btn查詢歷史紀錄);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(1408, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 960);
            this.groupBox3.TabIndex = 97;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Level 5";
            // 
            // lbl累積得獎金額
            // 
            this.lbl累積得獎金額.AutoSize = true;
            this.lbl累積得獎金額.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl累積得獎金額.Location = new System.Drawing.Point(75, 899);
            this.lbl累積得獎金額.Name = "lbl累積得獎金額";
            this.lbl累積得獎金額.Size = new System.Drawing.Size(357, 40);
            this.lbl累積得獎金額.TabIndex = 2;
            this.lbl累積得獎金額.Text = "累積得獎金額：0000 元";
            // 
            // btn查詢歷史紀錄
            // 
            this.btn查詢歷史紀錄.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn查詢歷史紀錄.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn查詢歷史紀錄.Location = new System.Drawing.Point(33, 49);
            this.btn查詢歷史紀錄.Name = "btn查詢歷史紀錄";
            this.btn查詢歷史紀錄.Size = new System.Drawing.Size(442, 75);
            this.btn查詢歷史紀錄.TabIndex = 0;
            this.btn查詢歷史紀錄.Text = "查詢歷史紀錄";
            this.btn查詢歷史紀錄.UseVisualStyleBackColor = false;
            this.btn查詢歷史紀錄.Click += new System.EventHandler(this.btn查詢歷史紀錄_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(19, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 40);
            this.label1.TabIndex = 98;
            this.label1.Text = "Level 4";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3.Location = new System.Drawing.Point(26, 148);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(844, 182);
            this.textBox3.TabIndex = 12;
            // 
            // textBox包牌顯示
            // 
            this.textBox包牌顯示.BackColor = System.Drawing.Color.White;
            this.textBox包牌顯示.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox包牌顯示.Location = new System.Drawing.Point(666, 545);
            this.textBox包牌顯示.Multiline = true;
            this.textBox包牌顯示.Name = "textBox包牌顯示";
            this.textBox包牌顯示.ReadOnly = true;
            this.textBox包牌顯示.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox包牌顯示.Size = new System.Drawing.Size(698, 419);
            this.textBox包牌顯示.TabIndex = 99;
            // 
            // textBox歷史紀錄
            // 
            this.textBox歷史紀錄.BackColor = System.Drawing.Color.White;
            this.textBox歷史紀錄.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox歷史紀錄.Location = new System.Drawing.Point(33, 148);
            this.textBox歷史紀錄.Multiline = true;
            this.textBox歷史紀錄.Name = "textBox歷史紀錄";
            this.textBox歷史紀錄.ReadOnly = true;
            this.textBox歷史紀錄.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox歷史紀錄.Size = new System.Drawing.Size(442, 729);
            this.textBox歷史紀錄.TabIndex = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.textBox包牌顯示);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn包牌);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn清除);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton10);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl隨機號碼;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btn產生號碼;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl筆數;
        private System.Windows.Forms.Button btn刪除所有號碼;
        private System.Windows.Forms.Button btn刪除所選號碼;
        private System.Windows.Forms.Button btn加入選號;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn輸入號碼;
        private System.Windows.Forms.Button btn開獎結果查詢;
        private System.Windows.Forms.Label lbl提示字;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.Button btn包牌;
        private System.Windows.Forms.Button btn清除;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn查詢歷史紀錄;
        private System.Windows.Forms.Label lbl累積得獎金額;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox包牌顯示;
        private System.Windows.Forms.TextBox textBox歷史紀錄;
    }
}

