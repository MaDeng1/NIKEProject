using System;
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
    public partial class MainForm : Form
    {
        //皮肤引擎对象
        Sunisoft.IrisSkin.SkinEngine se = null;

        public MainForm()
        {
            InitializeComponent();
            //加载皮肤
            se = new Sunisoft.IrisSkin.SkinEngine();
            se.SkinAllForm = true;
            se.SkinFile = "skin/" + Settings.SkinName + ".ssk";
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            this.lbl_welcome.Text =  LoginInfo.UserName + "(" + LoginInfo.RoleName + ")，欢迎您！";
            this.lbl_now.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString() + "  " + DateTime.Now.ToString("dddd");
            //this.label13.Text = DateTime.Now.DayOfWeek.ToString();

            //加载首页广告
            AddTab("首页", new ADForm());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbl_now.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString()+DateTime.Now.ToString("dddd");
        }

        private void cb_skin_SelectedIndexChanged(object sender, EventArgs e)
        {
            //保存皮肤名称
            Settings.SkinName = this.cb_skin.Text;
            if (Settings.SkinName == "默认皮肤")
                se.Active = false;
            else
            {
                se.Active = true;
                se.SkinFile = "skin/" + Settings.SkinName + ".ssk";
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.panel3.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.panel3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            this.panel4.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.panel4.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            this.panel5.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            this.panel5.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            this.panel6.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            this.panel6.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            this.panel8.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            this.panel8.BorderStyle = BorderStyle.FixedSingle;
        }
       

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            this.panel7.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            this.panel7.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            this.panel10.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            this.panel10.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            this.panel9.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            this.panel9.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            this.panel12.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            this.panel12.BorderStyle = BorderStyle.FixedSingle;
        }

        //商品入库按钮
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RuKu putinForm = new RuKu();
            putinForm.ShowDialog();
        }
        //商品浏览按钮
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LiuLan goodsViewForm = new LiuLan();
            AddTab("商品浏览", goodsViewForm);
        }
        //退货按钮
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            TuiHuo returnOfGoodsForm = new TuiHuo();
            //AddTab("商品退货", returnOfGoodsForm);
            returnOfGoodsForm.ShowDialog();
        }
        //收银台按钮
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Shouyin cashForm = new Shouyin();
            cashForm.Show();
        }
        //销售统计按钮
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            TongJi saleInfoForm = new TongJi();
            AddTab("销售统计", saleInfoForm);
        }

        //工资核算按钮
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            GongZi salaryInfoForm = new GongZi();
            AddTab("工资核算", salaryInfoForm);
        }

        //商品分类按钮
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            AddTab("商品分类管理", new FenLei());
        }

        //员工管理
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            AddTab("员工管理", new YuanGong());
        }
        //系统配置
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            new XiTong().ShowDialog();
        }


        private void AddTab(string tabName, Form form)
        {
            //根据标签文本，判断该选项卡页是否已经存在，防止重复
            if (TabIsExist(tabName))
            {
                return;
            }

            //选项卡页不存在，需要动态创建
            //创建选项卡页，并设置标签文本
            TabPage tp_view = new TabPage(tabName);

            //将窗体form添加到TabControl控件中
            //注意：在TabPage中放窗体，需要给窗体设置以下两个属性

            form.TopLevel = false;  //设置为非顶级控件，否则运行报错

            form.Visible = true;    //设置为可见，否则窗体内容不显示

            tp_view.Controls.Add(form);//将窗体添加至TabPage中

            //将TabPage对象添加至TabContro1中
            this.tabControl1.TabPages.Add(tp_view);
            //添加后，选中该选项卡页
            this.tabControl1.SelectedTab = tp_view;
        }
        //判断选项卡页是否已经存在
        private  bool TabIsExist(string tabName)
        {
            //先假设该选项卡不存在
            bool isExist = false;
            //遍历所有选项卡页，验证假设是否成立
            foreach (TabPage page in this.tabControl1.TabPages)
            {
                if(page.Text == tabName)
                {
                    //假设不成立，更改结果
                    isExist = true;
                    //选项卡页已经存在，直接选中该选项卡
                    this.tabControl1.SelectedTab = page;
                    break;
                }
            }
            //返回最终结果
            return isExist;
        }

        //双击标签，移除选项卡页
        private void tabControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //获取当前选中的Tab标签
            TabPage selectedPage = this.tabControl1.SelectedTab;
            //首页标签不允许移除
            if (selectedPage.Text == "首页") return;
            //移除选中的标签
            this.tabControl1.TabPages.Remove(selectedPage);
        }

        
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lbl_welcome_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            //this.label13.Text = DateTime.Now.DayOfWeek.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        { 

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }
    }

}
