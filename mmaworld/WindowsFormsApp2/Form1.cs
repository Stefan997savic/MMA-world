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
        //lista za cuvanje drzava
        List<Class1> countryList = new List<Class1>();

        //trenutni id
        int currentID = 1;

        //ispisuje drzave u listbox
        private void addList()
        {
            listBox1.Items.Clear();
            foreach (Class1 drzava in countryList)
            {
                listBox1.Items.Add(drzava);
            }
        }
        public Form1()
        {
            
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //uzimanje vrednosti iz txt boksa i dodavanje id drzavi
            int IdCountry = currentID;
            String name = txtName.Text;
            String iso2 = txtISO2.Text;
            String iso3 = txtISO3.Text;
            String nameSRB = txtNameSrb.Text;

            //kreiranje objekta i dodavanje u listu 
            Class1 newCountry = new Class1(IdCountry,name,iso2,iso3,nameSRB);
            countryList.Add(newCountry);

            //povecava se id svaki put za 1
            currentID++;
           
            //Dodavanje objekta u listu
            addList();

            
            txtName.Text = "";
            txtNameSrb.Text = "";
            txtISO2.Text = "";
            txtISO3.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //brise selectovani item iz list boxa
            if(listBox1.SelectedItems != null)
            {
                Class1 selectCountry = (Class1)listBox1.SelectedItem;
                countryList.Remove(selectCountry);
                addList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //proverava da li je izabrana neka stavka iz listboxa
           if (listBox1.SelectedItems != null)
            {
                //uzima odabranu drzavu
                Class1 selectCountry = (Class1)listBox1.SelectedItem;

                //otvara dijalog prozore za izmenu drzava
                string newName = Prompt.ShowDialog("Unesite novo ime drzave:", "Izmena drzave", selectCountry.Name);
                string newIso2 = Prompt.ShowDialog("Unesite novi ISO2:", "Izmena drzave", selectCountry.ISO2);
                string newIso3 = Prompt.ShowDialog("Unesite novi ISO3:", "Izmena drzave", selectCountry.ISO3);
                string newNameSrb = Prompt.ShowDialog("Unesite novo ime drzave na srb:", "Izmena drzave", selectCountry.NameSRB);

                //proverava da li je korisnik uneo izmenu i azurira
                if (!string.IsNullOrWhiteSpace(newName) && !string.IsNullOrWhiteSpace(newIso2) && !string.IsNullOrWhiteSpace(newIso3) && !string.IsNullOrWhiteSpace(newNameSrb))
                {
                    selectCountry.ISO3 = newIso3;
                    selectCountry.ISO2 = newIso2;
                    selectCountry.NameSRB = newNameSrb;
                    selectCountry.Name = newName;
                    addList();
                }
            }
           
            
        }


        //dijalog prozor za unos podataka
        public static class Prompt
        {
            public static string ShowDialog(string caption, string text, string defaultValue = "")
            {
                Form prompt = new Form()
                {
                    Width = 300,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 200, Text = defaultValue };
                Button confirmation = new Button() { Text = "Potvrdi", Left = 100, Width = 100, Top = 80, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
        }
    }
}
