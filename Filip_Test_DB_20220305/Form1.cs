
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
                    listVypis.Items.Add(faktura.cena);
                    listVypis.Items.Add(faktura.cislo);
                    listVypis.Items.Add(faktura.datum);

                }
            }
        }
    }

