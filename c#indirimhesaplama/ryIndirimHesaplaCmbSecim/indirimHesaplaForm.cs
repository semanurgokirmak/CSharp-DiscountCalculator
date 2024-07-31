using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ryIndirimHesaplaCmbSecim
{
    public partial class indirimHesaplaForm : Form
    {
        public indirimHesaplaForm()
        {
            InitializeComponent();
        }

        private void cmbIndirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbTutar.Text.Trim() !="")
            {
                double tutar = float.Parse(tbTutar.Text);
                double Sonuc;
                switch (cmbIndirim.Text)
                {
                    case "10": 
                        {
                            //tutar = tutar - (tutar * 0.10);
                            ////tutar -= (tutar * 0.10);
                            //tbIndirimTutar.Text = tutar.ToString();
                            tbIndirimTutar.Text = (tutar -= (tutar * 0.10)).ToString();
                        }break;
                    case "15": { tbIndirimTutar.Text = (tutar -= (tutar * 0.15)).ToString(); }break;
                    case "20": { tbIndirimTutar.Text = (tutar -= (tutar * (double.Parse(cmbIndirim.Text)/100))).ToString(); } break;
                    default: { tbIndirimTutar.Text = (tutar -= (tutar * double.Parse(cmbIndirim.Text)/100)).ToString(); } break;
                }
            }
        }

        private void cmbKdvOran_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbIndirimTutar.Text.Trim() !="")
            {
                double tutar = double.Parse(tbIndirimTutar.Text);
                double KdvMiktar;
                double ToplamTutar;
                if (cmbKdvOran.SelectedIndex==0)
                {
                    KdvMiktar = tutar * 0.01;
                    tbKdvMiktar.Text = KdvMiktar.ToString();
                    ToplamTutar = tutar + KdvMiktar;
                    tbToplamTutar.Text = ToplamTutar.ToString();

                }
                else if (cmbKdvOran.SelectedIndex==1)
                {
                    tbKdvMiktar.Text = (KdvMiktar = tutar * 0.1).ToString();
                    tbToplamTutar.Text = (ToplamTutar = tutar + KdvMiktar).ToString();
                }
                else
                {
                    tbKdvMiktar.Text = (tutar * 0.2).ToString();
                    tbToplamTutar.Text = (tutar + double.Parse(tbKdvMiktar.Text)).ToString();
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istiyor musunuz?", "Çıkış Onayı", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
