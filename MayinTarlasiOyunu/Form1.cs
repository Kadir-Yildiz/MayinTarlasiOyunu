using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayinTarlasiOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MayinTarlasi mayinTarlasi;
        List<Mayin> mayinlarimiz;
        int bayrakSayisi = 40;
        int bulunan = 0;
        int sure=0;


        private void Form1_Load(object sender, EventArgs e)
        {
            YenidenBasla();
        }

        public void MayinEkle()
        {
            for (int x = 0; x < panel1.Width; x = x + 20)
            {
                for (int y = 0; y < panel1.Height; y = y + 20)
                {
                    ButtonEkle(new Point(x, y));
                }
            }
        }

        public void ButtonEkle(Point loc)
        {
            Button btn = new Button();
            btn.Name = loc.X + "" + loc.Y;
            btn.Size = new Size(20, 20);
            btn.Location = loc;
            btn.MouseDown += new MouseEventHandler(btn_MouseDown);
            panel1.Controls.Add(btn);

        }

        void btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (bayrakSayisi > 1)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Button btn = (sender as Button);
                    Mayin myn = mayinTarlasi.MayinAlLocation(btn.Location);
                    mayinlarimiz = new List<Mayin>();
                    if (myn.mayinVarmi)
                    {
                        MayinlariGoster();
                        btnYenidenBasla.BackgroundImage = Properties.Resources.Bitti;
                        MessageBox.Show("KAYBETTİN!");
                        bulunan = 0;
                        
                    }
                    else
                    {
                        int sayi = EtrafindaKacMayinVar(myn);
                        if (sayi == 0)
                        {
                            mayinlarimiz.Add(myn);
                            for (int i = 0; i < mayinlarimiz.Count; i++)
                            {
                                Mayin item = mayinlarimiz[i];
                                if (item != null)
                                {

                                    if (item.BakildiMi == false && item.mayinVarmi == false)
                                    {
                                        Button btn1 = (Button)panel1.Controls.Find(item.konumAl.X + "" + item.konumAl.Y, false)[0];
                                        if (EtrafindaKacMayinVar(mayinlarimiz[i]) == 0)
                                        {
                                            btn1.Enabled = false;
                                            CevresindekileriEkle(item);
                                        }
                                        else
                                        {
                                            btn1.Text = EtrafindaKacMayinVar(item).ToString();
                                        }
                                        bulunan++;
                                        item.BakildiMi = true;
                                    }
                                }
                            }
                        }
                        else
                        {
                            btn.Text = sayi.ToString();
                            bulunan++;
                        }
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    --bayrakSayisi;
                    Button btn = (sender as Button);
                    btn.BackgroundImage = Properties.Resources.bayrak;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    lblBayrakSayisi.Text = bayrakSayisi.ToString();
                } 
            }
            else
            {
                if (bulunan>=360)
                {
                    MessageBox.Show("KAZANDIN!");
                    bulunan = 0;
                }
                else
                {
                    btnYenidenBasla.BackgroundImage = Properties.Resources.Bitti;
                    MessageBox.Show("KAYBETTİN!");
                    bulunan = 0;
                    
                }
            }
        }

        public int EtrafindaKacMayinVar(Mayin m)
        {
            int sayi = 0;
            if (m.konumAl.X > 0)
            {
                if (mayinTarlasi.MayinAlLocation(new Point(m.konumAl.X - 20, m.konumAl.Y)).mayinVarmi)
                {
                    sayi++;
                }

            }
            if (m.konumAl.Y < panel1.Height - 20 && m.konumAl.X < panel1.Width - 20)
            {
                if (mayinTarlasi.MayinAlLocation(new Point(m.konumAl.X + 20, m.konumAl.Y + 20)).mayinVarmi)
                {
                    sayi++;
                }
            }
            if (m.konumAl.X < panel1.Width - 20)
            {
                if (mayinTarlasi.MayinAlLocation(new Point(m.konumAl.X + 20, m.konumAl.Y)).mayinVarmi)
                {
                    sayi++;
                }
            }
            if (m.konumAl.X > 0 && m.konumAl.Y > 0)
            {
                if (mayinTarlasi.MayinAlLocation(new Point(m.konumAl.X - 20, m.konumAl.Y - 20)).mayinVarmi)
                {
                    sayi++;
                }
            }
            if (m.konumAl.Y > 0)
            {
                if (mayinTarlasi.MayinAlLocation(new Point(m.konumAl.X, m.konumAl.Y - 20)).mayinVarmi)
                {
                    sayi++;
                }
            }
            if (m.konumAl.X > 0 && m.konumAl.Y < panel1.Height - 20)
            {
                if (mayinTarlasi.MayinAlLocation(new Point(m.konumAl.X - 20, m.konumAl.Y + 20)).mayinVarmi)
                {
                    sayi++;
                }
            }
            if (m.konumAl.Y < panel1.Height - 20)
            {
                if (mayinTarlasi.MayinAlLocation(new Point(m.konumAl.X, m.konumAl.Y + 20)).mayinVarmi)
                {
                    sayi++;
                }
            }
            if (m.konumAl.X > panel1.Width - 20 && m.konumAl.Y > 0)
            {
                if (mayinTarlasi.MayinAlLocation(new Point(m.konumAl.X + 20, m.konumAl.Y - 20)).mayinVarmi)
                {
                    sayi++;
                }
            }
            return sayi;
        }
        public void CevresindekileriEkle(Mayin m)
        {
            bool b1 = false;
            bool b2 = false;
            bool b3 = false;
            bool b4 = false;
            if (m.konumAl.X > 0)
            {
                mayinlarimiz.Add(mayinTarlasi.MayinAlLocation(new Point(m.konumAl.X - 20, m.konumAl.Y)));
                b1 = true;
            }
            if (m.konumAl.Y > 0)
            {
                mayinlarimiz.Add(mayinTarlasi.MayinAlLocation(new Point(m.konumAl.X, m.konumAl.Y - 20)));
                b2 = true;
            }
            if (m.konumAl.X < panel1.Width)
            {
                mayinlarimiz.Add(mayinTarlasi.MayinAlLocation(new Point(m.konumAl.X + 20, m.konumAl.Y)));
                b3 = true;
            }
            if (m.konumAl.Y < panel1.Height)
            {
                mayinlarimiz.Add(mayinTarlasi.MayinAlLocation(new Point(m.konumAl.X, m.konumAl.Y + 20)));
                b4 = true;
            }
            if (b1 && b2)
            {
                mayinlarimiz.Add(mayinTarlasi.MayinAlLocation(new Point(m.konumAl.X - 20, m.konumAl.Y - 20)));
            }
            if (b1 && b4)
            {
                mayinlarimiz.Add(mayinTarlasi.MayinAlLocation(new Point(m.konumAl.X - 20, m.konumAl.Y + 20)));
                b4 = true;
            }
            if (b2 && b3)
            {
                mayinlarimiz.Add(mayinTarlasi.MayinAlLocation(new Point(m.konumAl.X + 20, m.konumAl.Y - 20)));
                b4 = true;
            }
            if (b2 && b4)
            {
                mayinlarimiz.Add(mayinTarlasi.MayinAlLocation(new Point(m.konumAl.X + 20, m.konumAl.Y + 20)));
                b4 = true;
            }

        }

        public void MayinlariGoster()
        {
            foreach (var item in mayinTarlasi.GetAllMayin)
            {
                if (item.mayinVarmi)
                {
                    Button btn = (Button)panel1.Controls.Find(item.konumAl.X + "" + item.konumAl.Y, false)[0];
                    btn.BackgroundImage = Properties.Resources.mayin;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }

        private void btnYenidenBasla_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            YenidenBasla();
            lblBayrakSayisi.Text = 40.ToString();
            sure = 0;
        }
        private void YenidenBasla()
        {
            panel2.Size = new Size(440, 500);
            panel2.SendToBack();
            panel2.BackgroundImage = Properties.Resources.ArkaPlanBos;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            mayinTarlasi = new MayinTarlasi(new Size(400, 400), 40);
            panel1.Size = mayinTarlasi.Buyuklugu;
            panel1.Left = panel2.Left;
            panel1.Top = panel2.Top;
            panel1.Location = new Point(100, 100);
            panel2.Location = new Point(82, 24);
            btnYenidenBasla.Size = new Size(36, 36);
            btnYenidenBasla.Location = new Point(282, 45);
            btnYenidenBasla.BackgroundImage = Properties.Resources.Basla;
            btnYenidenBasla.BackgroundImageLayout = ImageLayout.Stretch;
            lblBayrakSayisi.Location = new Point(30, 24);
            lblBayrakSayisi.Text = bayrakSayisi.ToString();
            lblSure.Location=new Point(445, 48);
            lblSure.Text= sure.ToString();
            timer1.Start();
            MayinEkle();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;
            lblSure.Text=sure.ToString();

        }
    }
}
