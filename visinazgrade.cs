using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visinazgrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            private void btnIzracunaj_Click(object sender, EventArgs e)
            {
                try
                {
                    int brojKatova = int.Parse(txtBrojKatova.Text);

                    Neboder neboder = new Neboder();
                    neboder.BrojKatova = brojKatova;

                    txtVisina.Text = neboder.IzracunajVisinu().ToString();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Unesite ispravan broj katova.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Došlo je do pogreške: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public class Neboder
        {
            private const double VisinaKata = 3.0;
            private int _brojKatova;

            public int BrojKatova
            {
                get { return _brojKatova; }
                set
                {
                    if (value < 0)
                        throw new ArgumentException("Broj katova ne može biti negativan.");

                    _brojKatova = value;
                }
            }

            public double IzracunajVisinu()
            {
                return BrojKatova * VisinaKata;
            }
        }
    }

