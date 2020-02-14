using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] member = { "農夫", "狼", "山羊", "青菜" };
        private void Form1_Load(object sender, EventArgs e)
        {
            string start = "農夫要帶著狼、山羊、青菜過河。小船不夠大，因此農夫每次只能帶一樣東西過河。當農夫在的時候，狼、羊、菜都不會有事情。當農夫不在時，狗會吃雞，雞會吃包心菜。";
            MessageBox.Show(start);
            LstLeft.Items.AddRange(member);
            LstLeft.Enabled = true;
            LstRight.Enabled = false;
            BtnBack.Enabled = false;
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            string s_item;
            LstLeft.Enabled = false;
            LstRight.Enabled = true;
            BtnGo.Enabled = false;
            BtnBack.Enabled = true;
            if (LstLeft.Text != "")
            {
                s_item = LstLeft.Text;
                LstLeft.Items.Remove(s_item);
                LstRight.Items.Add(s_item);
                if (s_item != "農夫")
                {
                    LstLeft.Items.Remove("農夫");
                    LstRight.Items.Add("農夫");
                }

                if (LstLeft.FindStringExact("山羊") != -1 && LstLeft.FindStringExact("青菜") != -1)
                {
                    MessageBox.Show("山羊吃掉青菜了");

                    LstLeft.Items.Clear();
                    LstLeft.Items.AddRange(member);
                    LstRight.Items.Clear();
                    LstLeft.Enabled = true;
                    LstRight.Enabled = false;
                    BtnGo.Enabled = true;
                    BtnBack.Enabled = false;
                }
                else
                {
                    if (LstLeft.FindStringExact("山羊") != -1 && LstLeft.FindStringExact("狼") != -1)
                    {
                        MessageBox.Show("狼吃掉山羊了");

                        LstLeft.Items.Clear();
                        LstLeft.Items.AddRange(member);
                        LstRight.Items.Clear();
                        LstLeft.Enabled = true;
                        LstRight.Enabled = false;
                        BtnGo.Enabled = true;
                        BtnBack.Enabled = false;
                    }
                }
            }
            if (LstRight.Items.Count == 4)
            {
                MessageBox.Show("任務完成了");
                LstLeft.Items.Clear();
                LstLeft.Items.AddRange(member);
                LstRight.Items.Clear();
                BtnGo.Enabled = true;
                BtnBack.Enabled = false;
                return;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            string s_item = "";
            LstLeft.Enabled = true;
            LstRight.Enabled = false;
            BtnGo.Enabled = true;
            BtnBack.Enabled = false;
            if (LstRight.Text != "")
            {
                s_item = LstRight.Text;
                LstRight.Items.Remove(s_item);
                LstLeft.Items.Add(s_item);
                if (s_item != "農夫")
                {
                    LstRight.Items.Remove("農夫");
                    LstLeft.Items.Add("農夫");
                }
                if (LstRight.FindStringExact("山羊") != -1 && LstRight.FindStringExact("青菜") != -1)
                {
                    MessageBox.Show("山羊吃了青菜");
                    LstLeft.Items.Clear();
                    LstLeft.Items.AddRange(member);
                    LstRight.Items.Clear();
                    LstLeft.Enabled = true;
                    LstRight.Enabled = false;
                    BtnGo.Enabled = true;
                    BtnBack.Enabled = false;
                }
                else
                {
                    if (LstRight.FindStringExact("山羊") != -1 && LstRight.FindStringExact("狼") != -1)
                    {
                        MessageBox.Show("山羊被狼吃掉了");
                        LstLeft.Items.Clear();
                        LstLeft.Items.AddRange(member);
                        LstRight.Items.Clear();
                        LstLeft.Enabled = true;
                        LstRight.Enabled = false;
                        BtnGo.Enabled = true;
                        BtnBack.Enabled = false;
                    }
                }
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            LstLeft.Items.Clear();
            LstLeft.Items.AddRange(member);
            LstRight.Items.Clear();
            LstLeft.Enabled = true;
            LstRight.Enabled = false;
            BtnGo.Enabled = true;
            BtnBack.Enabled = false;
        }
    }
}
