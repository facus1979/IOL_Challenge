using Library.CodingChallenge;
using Library.CodingChallenge.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace App.CodingChallenge
{
    public partial class Main : Form
    {
        List<FormaGeometrica> l;
        DataTable dt;
        public Main()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            l = new List<FormaGeometrica>();
            dt = new DataTable();
            dt.Columns.Add("Figura");
            dt.Columns.Add("Lado");
        }

        private void Add_Click(object sender, EventArgs e)
        {
            decimal lado = 0;
           

            if (txt_lado.Text == "") {

                MessageBox.Show("Ingrese un valor a Lado");
                return;
            }

            if (!decimal.TryParse(txt_lado.Text, out lado))
            {
                MessageBox.Show("Valor de lado invalido");
                return;
            }

            try
            {
                switch (comboBox1.SelectedItem)
                {
                    case "Cuadrado":
                        Cuadrado cd = new Cuadrado(lado);
                        dt.Rows.Add("Cuadrado", lado);
                        l.Add(cd);
                        break;
                    case "Circulo":
                        Circulo cc = new Circulo(lado);
                        dt.Rows.Add("Circulo", lado);
                        l.Add(cc);
                        break;
                    case "Triangulo Equilatero":
                        TrianguloEquilatero te = new TrianguloEquilatero(lado);
                        dt.Rows.Add("Triangulo Equilatero", lado);
                        l.Add(te);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            var source = new BindingSource(dt, null);
            dataGridView1.DataSource = source;
            txt_lado.Text = "";
            this.Refresh();
        
        }

        private void Gen_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate("about:blank");
            webBrowser1.Document.OpenNew(false);

            ReportManager rm = new ReportManager();

            string report =rm.Print(l, (comboBox2.SelectedItem.ToString() == "Ingles" ? ReportManager.Idiomas.Ingles : ReportManager.Idiomas.Castellano));

            webBrowser1.Document.Write(report);
            webBrowser1.Refresh();

            dt.Rows.Clear();
            l.Clear();
            this.Refresh();
        }
    }

}
