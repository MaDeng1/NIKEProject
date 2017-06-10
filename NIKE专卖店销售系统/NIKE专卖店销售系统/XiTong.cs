﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIKE专卖店销售系统
{
    public partial class XiTong : Form
    {
        public XiTong()
        {
            InitializeComponent();
        }

        private void SystemConfigForm_Load(object sender, EventArgs e)
        {
            this.txt_shopName.Text = Settings.ShopName;
            this.txt_skinName.Text = Settings.SkinName;
            this.txt_BaseSaleroom.Text = Settings.BaseSaleroom.ToString();
            this.txt_adImagePath.Text = Settings.AdImagePath;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txt_shopName.Text == "" || this.txt_skinName.Text == "" || this.txt_BaseSaleroom.Text == "" || this.txt_adImagePath.Text == "")
            {
                MessageBox.Show("配置信息不能为空！");
                return;
            }
            int BaseSaleroom;
            if (int.TryParse(this.txt_BaseSaleroom.Text, out BaseSaleroom))
            {
                MessageBox.Show("设置成功 ！");
                return;
            }
            else
            {
                MessageBox.Show("月度考核保底销售额必须为数字 ！");
            }
            Settings.ShopName = this.txt_shopName.Text;
            Settings.SkinName = this.txt_skinName.Text;
            Settings.BaseSaleroom= float.Parse(this.txt_BaseSaleroom.Text);
            Settings.AdImagePath = this.txt_adImagePath.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_shopName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
