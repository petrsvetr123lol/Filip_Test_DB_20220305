using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Filip_Test_DB_20220305
{
    public partial class Form1 : Form
    {
     
            List<Faktury> faktury;
            SqlRepository sqlRepository = new SqlRepository();
            public Form1()
            {
                InitializeComponent();
                faktury = sqlRepository.GetFaktura();
                RefreshGUI();
            }

            private void RefreshGUI()
            {
                listVypis.Items.Clear();
                foreach (Faktury faktura in faktury)
                {
                    float cena_celkem = faktura.pocet * faktura.cena;
                    double cena_dph = cena_celkem * 0.21;
                    double full_cena_dph = cena_celkem + cena_dph;
                    listVypis.Items.Add("Faktura číslo " + faktura.id);
                    listVypis.Items.Add("datum: " + faktura.datum);
                    listVypis.Items.Add("číslo položky: " + faktura.cislo);
                    listVypis.Items.Add("odběrate: "+ faktura.odberatel);
                    listVypis.Items.Add("název položky: " + faktura.nazev);
                    listVypis.Items.Add("počet položek: " + faktura.pocet);
                    listVypis.Items.Add("cena za položku: " + faktura.cena + " Kč");
                    listVypis.Items.Add("cena celkem: " + cena_celkem + " Kč");
                    listVypis.Items.Add("DPH: " + cena_dph + " Kč");
                    listVypis.Items.Add("Cena celkem s DPH: " + full_cena_dph + " Kč");
                    listVypis.Items.Add("====================================");
                }
            
            }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("zbastleno Petrem Filipem");
        }
    }
    }

