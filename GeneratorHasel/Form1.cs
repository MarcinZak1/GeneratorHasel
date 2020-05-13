using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratorHasel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> wszystkieHasla = new List<string>();
        Random random = new Random((int)DateTime.Now.Ticks);
        StringBuilder haslo = new StringBuilder();
        private void btn_Click(object sender, EventArgs e)
        {
            listaHasel.Items.Clear();
            byte passwordLength = Convert.ToByte(dlugoscHasla.Value);
            char[] tab = new char[passwordLength];
            int iloscHasel = Convert.ToInt32(liczbaHasel.Value);

            for (int i = 0; i < iloscHasel; i++)
            {
                if (rbCyfry.Checked)
                {
                    WyborCyfry(passwordLength);

                    if (wszystkieHasla.Contains(haslo.ToString()))
                    {
                        while (wszystkieHasla.Contains(haslo.ToString()))
                        {
                            haslo.Clear();
                            WyborCyfry(passwordLength);
                        }
                        DodawanieHasla();
                    }
                    else if (!wszystkieHasla.Contains(haslo.ToString()))
                    {
                        DodawanieHasla();
                    }
                }
                else if (rbCyfryiLit.Checked)
                {
                    WyborCyfryiLit(passwordLength, tab);
                    if (wszystkieHasla.Contains(haslo.ToString()))
                    {
                        while (wszystkieHasla.Contains(haslo.ToString()))
                        {
                            haslo.Clear();
                            WyborCyfryiLit(passwordLength, tab);
                        }
                        DodawanieHasla();
                    }
                    else if (!wszystkieHasla.Contains(haslo.ToString()))
                    {
                        DodawanieHasla();
                    }
                }
                else if (rbWszystko.Checked)
                {
                    WyborWszystko(passwordLength);
                    if (wszystkieHasla.Contains(haslo.ToString()))
                    {
                        while (wszystkieHasla.Contains(haslo.ToString()))
                        {
                            haslo.Clear();
                            WyborWszystko(passwordLength);
                        }
                        DodawanieHasla();
                    }
                    else if (!wszystkieHasla.Contains(haslo.ToString()))
                    {
                        DodawanieHasla();
                    }
                }
            }
        }

        private void listaHasel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(listaHasel.SelectedItem.ToString());
        }
        private void DodawanieHasla()
        {
            listaHasel.Items.Add(haslo.ToString());
            wszystkieHasla.Add(haslo.ToString());
            haslo.Clear();
        }
        private void WyborCyfry(byte passwordLength)
        {
            for (int j = 0; j < passwordLength; j++)
            {
                haslo.Append((char)(random.Next(48, 58)));
            }
        }
        private void WyborCyfryiLit(byte passwordLength, char[] tab)
        {
            for (int j = 0; j < passwordLength; j++)
            {
                tab[j] = ((char)random.Next(48, 123));
                if ((tab[j] > 57 && tab[j] < 65) || (tab[j] > 90 && tab[j] < 97))
                {
                    while ((tab[j] > 57 && tab[j] < 65) || (tab[j] > 90 && tab[j] < 97))
                    {
                        tab[j] = ((char)random.Next(48, 123));
                    }
                }
                haslo.Append(tab[j]);
            }
        }
        private void WyborWszystko(byte passwordLength)
        {
            for (int j = 0; j < passwordLength; j++)
            {
                haslo.Append((char)(random.Next(33, 126)));
            }
        }
    }
}
