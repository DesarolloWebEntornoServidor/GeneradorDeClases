using System;

using System.Windows.Forms;

namespace GeneradorDeClases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCrear_Click(object sender, EventArgs e)
        {

            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count-2].Cells[0];

            if (txbNomClase.Text.Trim().Length == 0 || Char.IsNumber((char)txbNomClase.Text[0]))
            {
                errorProvider1.SetError(txbNomClase, "El nombre de la clase no puede estar vacio, ni empezar con número");
                rtMostraClase.Text = "";

                return;
            }
            errorProvider1.SetError(txbNomClase, "");

            string nomTipo = "";
            string nomAtrib = "";

            if (dataGridView1.Rows.Count <= 1)
            {
                 MessageBox.Show("Tienes que informar algun atributo", "", MessageBoxButtons.OK);
                rtMostraClase.Text = "";

                return;
            }

            try
            {
                nomTipo = dataGridView1.CurrentRow.Cells[0].Value.ToString(); // verifica tipo vacio
                nomAtrib = dataGridView1.CurrentRow.Cells[1].Value.ToString(); // verifica nombre vacio

                    char c = nomAtrib[0];
                    if (Char.IsNumber(c)) // verifica de empieza con numero
                    {

                        MessageBox.Show("No puede empiezar con número", "", MessageBoxButtons.OK);
                    rtMostraClase.Text = "";

                    return;
                    }
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("Nombre o Tipo no puede estar vacio", "", MessageBoxButtons.OK);
                rtMostraClase.Text = "";

                return;
            }

            if (!Convert.ToBoolean(dataGridView1.CurrentRow.Cells[2].Value) && !Convert.ToBoolean(dataGridView1.CurrentRow.Cells[3].Value)) // verifica se get o set está marcado
            {
                MessageBox.Show("Get y Set no pueden estar desmarcados", "", MessageBoxButtons.OK);
                rtMostraClase.Text = "";

                return;
            }


                for (int i = 0; i < dataGridView1.Rows.Count-1 ; i++) // construye los atributos
                {
                    nomTipo = dataGridView1.Rows[i].Cells["tipo"].Value.ToString();
                    nomAtrib = dataGridView1.Rows[i].Cells["nombre"].Value.ToString();

                    rtMostraClase.Text = "\n\nusing System;" + "\r\n";

                    rtMostraClase.Text += "\npublic class " + txbNomClase.Text.Substring(0, 1).ToUpper() + txbNomClase.Text.Substring(1) + "\r\n\t{\n";


                    rtMostraClase.Text += "\tprivate " + nomTipo + " " + nomAtrib + ";\r\n";
                }

            rtMostraClase.Text += "\r\n\tpublic " + txbNomClase.Text.Substring(0, 1).ToUpper() + txbNomClase.Text.Substring(1) + "(";

            int virgula = 0;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) // construye el constructor
            {
                if (virgula > 0)
                    rtMostraClase.Text += ",";

                    nomTipo = dataGridView1.Rows[i].Cells["tipo"].Value.ToString();
                    nomAtrib = dataGridView1.Rows[i].Cells["nombre"].Value.ToString();


                rtMostraClase.Text += nomTipo + " " + nomAtrib;
                virgula++;
            }

            
            rtMostraClase.Text += ")" + "\n" + "\t" + "{" + "\r\n";
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) // construye las Propriedades
            {

                    nomTipo = dataGridView1.Rows[i].Cells["tipo"].Value.ToString();
                    nomAtrib = dataGridView1.Rows[i].Cells["nombre"].Value.ToString();

                rtMostraClase.Text += "\t\tthis." + nomAtrib + "=" + nomAtrib + ";\r\n";
            }
            rtMostraClase.Text += "\t" + "}" + "\r\n";

            rtMostraClase.Text += "\n\t#region Propriedades" + "\r\n";

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) // construye los atributos
            {

                    nomTipo = dataGridView1.Rows[i].Cells["tipo"].Value.ToString();
                    nomAtrib = dataGridView1.Rows[i].Cells["nombre"].Value.ToString();

                    rtMostraClase.Text += "\tPublic " + nomTipo + " " + nomAtrib.Substring(0, 1).ToUpper() + nomAtrib.Substring(1) + "\r\n\t{";


                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["get"].Value) && Convert.ToBoolean(dataGridView1.Rows[i].Cells["set"].Value))  // get y set
                {
                    rtMostraClase.Text += "\n\t\tget { return " + nomAtrib + "; }";

                    rtMostraClase.Text += "\n\t\tset { " + nomAtrib + " = value; }";
                    rtMostraClase.Text += " \n\t}\n";
                }
                else if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["set"].Value)) // set
                {
                    rtMostraClase.Text += "\n\t\tset { " + nomAtrib + " = value; }";
                    rtMostraClase.Text += " \n\t}\n";
                }
                else
                {
                    rtMostraClase.Text += "\n\t\tget { return " + nomAtrib + "; }"; // get
                    rtMostraClase.Text += " \n\t}\n";
                }

            }

            rtMostraClase.Text += "\n\t#endregion" + "\r\n    }";

            //rtMostraClase.Text += "\r\n}";
        }

        private void rtMostraClase_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            rtMostraClase.Text = "";
        }
    }
}
