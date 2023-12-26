using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> number = new List<string>();
        List<List<string>> number2 = new List<List<string>>();
        List<string> number3 = new List<string>();//包牌選擇號碼
        List<List<string>> number4 = new List<List<string>>();//包牌隨機產生號碼
        List<int> total = new List<int>();//累積得獎金額
        public List<System.Windows.Forms.Button> listPGButtons = new List<System.Windows.Forms.Button>();
        string history = "";
        bool restart = false;
        int star = 0;
        int[,] money = new int[10, 11]//星,獎
        {
            { 0,50,0,0,0,0,0,0,0,0,0},
            { 0,25,75,0,0,0,0,0,0,0,0},
            { 0,0,50,500,0,0,0,0,0,0,0},
            { 0,0,25,100,1000,0,0,0,0,0,0},
            { 0,0,0,50,500,7500,0,0,0,0,0},
            { 0,0,0,25,200,1000,25000,0,0,0,0},
            { 0,0,0,25,50,300,3000,80000,0,0,0},
            { 25,0,0,0,25,200,1000,20000,500000,0,0},
            { 25,0,0,0,25,100,500,3000,100000,1000000,0},
            { 25,0,0,0,0,25,250,2500,25000,250000,5000000}
        };
        public Form1()
        {
            InitializeComponent();
            btn加入選號.Enabled = false;
            btn開獎結果查詢.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            程式化語法產生按鈕(10, 8);
        }
        void 顯示筆數()
        {
            lbl筆數.Text = $"共{listBox.Items.Count}筆";
        }

        void 超過上限處理()
        {
            number3.Clear();
            for (int i = 0; i < listPGButtons.Count; i++)
            {
                listPGButtons[i].BackColor = Color.SkyBlue;
            }
            MessageBox.Show("選取號碼數量超過限制，請重新選取!");
        }

        private void btn產生號碼_Click(object sender, EventArgs e)
        {
            btn加入選號.Enabled = true;
            Random r = new Random();
            lbl隨機號碼.Text = string.Format("{0:D2}", r.Next(1, 81));
        }

        private void btn加入選號_Click(object sender, EventArgs e)
        {

            if (listBox.Items.Count >= 10)
            {
                MessageBox.Show("筆數超過10筆，無法加入選號!");
            }
            else if (number.Contains(lbl隨機號碼.Text))
            {
                MessageBox.Show("此號碼已存在，請勿重複加入!");
            }
            else
            {
                number.Add(lbl隨機號碼.Text);
                number.Sort();
                listBox.Items.Clear();
                for (int i = 0; i < number.Count; i++)
                {
                    listBox.Items.Add(number[i]);
                }
                顯示筆數();
            }
        }

        private void btn刪除所選號碼_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex >= 0)
            {
                number.RemoveAt(listBox.SelectedIndex);
                listBox.Items.RemoveAt(listBox.SelectedIndex);
                顯示筆數();
            }
        }

        private void btn刪除所有號碼_Click(object sender, EventArgs e)
        {
            number.Clear();
            listBox.Items.Clear();
            顯示筆數();
        }

        private void btn開獎結果查詢_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            List<string> bingo = new List<string>();
            string str = "";
            string temp = "";
            string time = string.Format("{0:F}", DateTime.Now); 
            int count = 0;
            //Console.WriteLine(time);
            textBox3.Text = "";
            history += time + "\r\n";
            while (bingo.Count < 20)
            {
                string s = string.Format("{0:D2}", r.Next(1, 81));
                if (bingo.Count == 0)
                    bingo.Add(s);
                else
                {
                    int flag = 0;//是否重複
                    foreach(string ss in bingo)
                    {
                        if (ss == s)
                        {
                            flag = 1;
                            break;
                        }
                    }
                    if(flag == 0)
                        bingo.Add(s);
                }
            }
            bingo.Sort();
            foreach (string s in bingo)
            {
                str = str + s + " ";
            }

            foreach (List<string> l in number2)
            {
                count++;
                string no = $"第{count}筆[{l.Count}星]：";
                string column = "";
                int awardnum = 0;//中獎數量
                foreach (string s in l)
                {
                    column = column + s + ' ';
                    if (bingo.Contains(s))
                    {
                        //Console.WriteLine($"count-1:{count - 1}");
                        awardnum++;
                    }
                }
                //Console.WriteLine($"count:{count}");
                //Console.WriteLine($"l.Count:{l.Count}");
                //Console.WriteLine($"獎金:{money[l.Count - 1, awardnum + 1]}");
                column = column + $",中{awardnum}獎 ," + $"獎金{money[l.Count - 1, awardnum]}元";
                total.Add(money[l.Count - 1, awardnum]);
                temp = temp + "\r\n" + no + column;
            }

            MessageBox.Show($"開獎號碼：{str}\n");
            //lbl已輸入號碼.Text = $"開獎號碼：{str}\n" + temp;
            textBox3.Text = $"開獎號碼：{str}\r\n" + temp;
            history += $"開獎號碼：{str}\r\n" + temp + "\r\n-------------------------------------\r\n";
            //Console.WriteLine(history);
            btn開獎結果查詢.Enabled = false;
            restart = true;
        }

        private void btn輸入號碼_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim();
            List<string> temp = new List<string>();
            string[] arrayNumber = textBox1.Text.Split(' ');
            bool TFsame = false;
            bool TFrange = true;
            int count = 0;
            textBox1.Text = "";
            if (restart)
            {
                //lbl已輸入號碼.Text = "";
                textBox3.Text = "";
                number2.Clear();
                restart = false;
            }
            try
            {
                for (int i = 0; i < arrayNumber.Length; i++)
                {
                    arrayNumber[i] = string.Format("{0:D2}", Convert.ToInt32(arrayNumber[i]));
                    //Console.WriteLine(arrayNumber[i]);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                textBox1.Text = "";
                return;
            }

            Array.Sort(arrayNumber);

            for (int i = 0; i < arrayNumber.Length; i++)
            {
                if (i <= arrayNumber.Length - 2 && arrayNumber[i] == arrayNumber[i + 1])
                {
                    TFsame = true;
                    break;
                }
                if (Convert.ToInt32(arrayNumber[i]) > 80 || Convert.ToInt32(arrayNumber[i]) <= 0)
                {
                    TFrange = false;
                    break;
                }
            }

            if (arrayNumber.Length > 10)
            {
                MessageBox.Show("超出輸入數量，請重新輸入!");
                textBox1.Text = "";
            }
            else if (TFsame)
            {
                MessageBox.Show("輸入號碼重複，請重新輸入!");
                textBox1.Text = "";
            }
            else if (TFrange == false)
            {
                MessageBox.Show("輸入號碼超出範圍，請重新輸入!");
                textBox1.Text = "";
            }
            else
            {
                btn開獎結果查詢.Enabled = true;
                textBox3.Text = "已輸入號碼：";
                foreach (string s in arrayNumber)
                {
                    temp.Add(s);
                }
                number2.Add(temp);
                foreach (List<string> l in number2)
                {
                    count++;
                    string no = $"第{count}筆：";
                    string column = "";
                    foreach (string s in l)
                    {
                        column = column + s + ' ';
                    }
                    textBox3.Text = textBox3.Text + "\r\n" + no + column;
                    //textBox3.Text = lbl已輸入號碼.Text;
                }
            }
            if (number2.Count != 0)
                btn開獎結果查詢.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            for(int i = 0;i < listPGButtons.Count; i++)
            {
                listPGButtons[i].BackColor = Color.SkyBlue;
                listPGButtons[i].Enabled = false;
            }
            star = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listPGButtons.Count; i++)
            {
                listPGButtons[i].Enabled = true;
            }
            star = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listPGButtons.Count; i++)
            {
                listPGButtons[i].Enabled = true;
            }
            star = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listPGButtons.Count; i++)
            {
                listPGButtons[i].Enabled = true;
            }
            star = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listPGButtons.Count; i++)
            {
                listPGButtons[i].Enabled = true;
            }
            star = 5;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listPGButtons.Count; i++)
            {
                listPGButtons[i].Enabled = true;
            }
            star = 6;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listPGButtons.Count; i++)
            {
                listPGButtons[i].Enabled = true;
            }
            star = 7;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listPGButtons.Count; i++)
            {
                listPGButtons[i].Enabled = true;
            }
            star = 8;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listPGButtons.Count; i++)
            {
                listPGButtons[i].Enabled = true;
            }
            star = 9;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listPGButtons.Count; i++)
            {
                listPGButtons[i].Enabled = true;
            }
            star = 10;
        }

        void 程式化語法產生按鈕(int col, int row)
        {
            int 號碼 = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    號碼 += 1;

                    System.Windows.Forms.Button dbutton = new System.Windows.Forms.Button();
                    dbutton.BackColor = Color.SkyBlue;
                    dbutton.ForeColor = Color.Black;
                    dbutton.Font = new Font("微軟正黑體", 12);
                    dbutton.Text = string.Format("{0:D2}", 號碼);
                    dbutton.Location = new Point(14 + 40 * j, 400 + 30 * i);
                    dbutton.Size = new Size(38, 30);
                    dbutton.Click += new EventHandler(dButton_Click); //+= -> 事件指定運算子,-= -> 事件解除運算子
                    dbutton.Name = $"btn{號碼}";
                    Controls.Add(dbutton);
                    listPGButtons.Add(dbutton);
                }
            }
        }
        private void dButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button myBtn = (System.Windows.Forms.Button)sender;
            if (myBtn.BackColor == Color.Pink)
            {
                myBtn.BackColor = Color.SkyBlue;
                //移出所選list號碼集合
                number3.Remove(myBtn.Text);
            }
            else
            {
                myBtn.BackColor = Color.Pink;
                //加入所選list號碼集合;
                number3.Add(myBtn.Text);
            }
        }

        private void btn包牌_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked && number3.Count > 1)
            {
                超過上限處理();
            }
            else if (radioButton3.Checked && number3.Count > 2)
            {
                超過上限處理();
            }
            else if (radioButton4.Checked && number3.Count > 3)
            {
                超過上限處理();
            }
            else if (radioButton5.Checked && number3.Count > 4)
            {
                超過上限處理();
            }
            else if (radioButton6.Checked && number3.Count > 5)
            {
                超過上限處理();
            }
            else if (radioButton7.Checked && number3.Count > 6)
            {
                超過上限處理();
            }
            else if (radioButton8.Checked && number3.Count > 7)
            {
                超過上限處理();
            }
            else if (radioButton9.Checked && number3.Count > 8)
            {
                超過上限處理();
            }
            else if (radioButton10.Checked && number3.Count > 9)
            {
                超過上限處理();
            }
            else
            {
                try
                {
                    int count = Convert.ToInt32(textBox2.Text);
                    int max = 1;
                    if (star == 1)
                        max = 80;
                    else
                    {
                        for (int i = 0; i < star - number3.Count; i++)
                        {
                            int n = 80 - number3.Count - i;
                            if (Int32.MaxValue / n >= max)
                            {
                                max *= n;
                            }
                            else
                                break;
                        }
                    }
                    //Console.WriteLine(star);
                    //Console.WriteLine($"number3.count = {number3.Count}");
                    Console.WriteLine($"max = {max}");
                    if (count > max)
                    {
                        MessageBox.Show("超過張數上限，請重新輸入!");
                        return;
                    }
                    //Console.WriteLine(count);
                    string str = "";
                    Random random = new Random();
                    for(int i = 0;i < count; i++)
                    {
                        string No = $"第{i + 1}筆：";
                        //Console.WriteLine(No);
                        string content = "";
                        if (number4.Count == 0)
                        {
                            List<string> temp = new List<string>();
                            content = "";
                            foreach(string s in number3)
                            {
                                temp.Add(s);
                            }

                            while (temp.Count < star)
                            {
                                string r = string.Format("{0:D2}", random.Next(1, 81));
                                if (!temp.Contains(r))
                                    temp.Add(r);
                            }
                            temp.Sort();
                            number4.Add(temp);
                            foreach (string s in number4[0])
                            {
                                content += s + " ";
                            }
                            //Console.WriteLine(content);
                            str += No + content + "\r\n";
                        }
                        else
                        {
                            List <string> temp = new List<string>();
                            foreach (string s in number3)
                            {
                                temp.Add(s);
                            }
                            content = "";
                            while (temp.Count < star)
                            {
                                string r = string.Format("{0:D2}", random.Next(1, 81));
                                if (!temp.Contains(r))
                                    temp.Add(r);
                            }
                            temp.Sort();
                            int flag = 0;//是否重複
                            foreach(List<string> l in number4)
                            {
                                if (l.SequenceEqual(temp))
                                {
                                    flag = 1;
                                    i--;
                                    break;
                                }
                            }
                            if (flag == 0)
                            {
                                number4.Add(temp);
                                foreach(string s in number4[i])
                                {
                                    content += s + " ";
                                }
                                //Console.WriteLine(content);
                                str += No + content + "\r\n";
                            }
                        }
                    }
                    textBox包牌顯示.Text = str;
                    btn包牌.Enabled = false;
                    //Console.WriteLine(str);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    return;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int count = 1;
            if (textBox2.Text != "")
            {
                bool is張數輸入正確 = Int32.TryParse(textBox2.Text, out count);

                if ((is張數輸入正確) == false || (count <= 0))
                {
                    MessageBox.Show("張數輸入錯誤,請重新輸入!");
                    count = 1;
                    textBox2.Text = count.ToString();
                }
            }
        }

        private void btn清除_Click(object sender, EventArgs e)
        {
            textBox包牌顯示.Text = "";
            number4.Clear();
            btn包牌.Enabled = true;
        }

        private void btn查詢歷史紀錄_Click(object sender, EventArgs e)
        {
            int money = 0;
            textBox歷史紀錄.Text = history;
            foreach(int n in total)
            {
                money += n;
            }
            lbl累積得獎金額.Text = "累積得獎金額： " + money.ToString() + " 元";
        }
    }
}
