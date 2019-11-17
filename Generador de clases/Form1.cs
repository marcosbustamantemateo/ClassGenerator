using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador_de_clases
{
    public partial class ClassGenerator : Form
    {
        List<String> errores = new List<string>();
        string atributo;

        public ClassGenerator()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            EliminarTexto(false);

            if (nombreClase.Text != "")
            {
                List<string> listaAtributos = new List<string>();
                codigo.AppendText("class " + nombreClase.Text + " {\n\n");

                // Atributos
                for (int i = 0; i < datos.Rows.Count; i++)
                {
                    try
                    {
                        String tipoDato = datos.Rows[i].Cells[0].Value.ToString();
                        String identificador = datos.Rows[i].Cells[1].Value.ToString();
                        Char primeraLetra = identificador[0];

                        if (Char.IsDigit(primeraLetra))
                        {
                            AnyadirError("First character of variable cannot be a number");
                        }

                        if (Char.IsUpper(primeraLetra))
                        {
                            AnyadirError("First character of variable cannot be Uppercase");
                        }

                        atributo = tipoDato + " " + identificador;
                        listaAtributos.Add(atributo);
                        codigo.AppendText("\t" + atributo + ";\n");
                    }
                    catch (NullReferenceException) { }
                }

                codigo.AppendText("\n");

                // Contructor
                codigo.AppendText("\tpublic " + nombreClase.Text + " (");
                for (int i = 0; i < listaAtributos.Count(); i++)
                {
                    codigo.AppendText(listaAtributos[i]);
                    if (i != listaAtributos.Count() - 1)
                        codigo.AppendText(", ");                    
                }

                codigo.AppendText(") {\n");

                for (int i = 0; i < listaAtributos.Count(); i++)
                    codigo.AppendText("\t\tthis." + listaAtributos[i].Split(' ')[1] + " = " + listaAtributos[i].Split(' ')[1] + ";\n");

                codigo.AppendText("\t}");

                // Propiedades
                codigo.AppendText("\n");
                string aux, mayus;
                for (int i = 0; i < listaAtributos.Count(); i++)
                {
                    aux = listaAtributos[i].Split(' ')[1];
                    mayus = Convert.ToString(aux[0]);

                    if (Convert.ToBoolean(datos.Rows[i].Cells[2].Value) || Convert.ToBoolean(datos.Rows[i].Cells[3].Value))
                    {
                        codigo.AppendText("\tpublic " + listaAtributos[i].Split(' ')[0] + " " + mayus.ToUpper() + aux.Remove(0, 1) + "\n\t{\n");
                        // get
                        if (Convert.ToBoolean(datos.Rows[i].Cells[2].Value))
                        {
                            codigo.AppendText("\t\tget\n\t\t{\n");
                            codigo.AppendText("\t\t\treturn " + listaAtributos[i].Split(' ')[1] + ";\n\t\t}\n");
                            
                        }
                        // set
                        if (Convert.ToBoolean(datos.Rows[i].Cells[3].Value))
                        {
                            if ((Convert.ToBoolean(datos.Rows[i].Cells[2].Value) && Convert.ToBoolean(datos.Rows[i].Cells[3].Value)) || Convert.ToBoolean(datos.Rows[i].Cells[3].Value))
                                codigo.AppendText("\t");

                            codigo.AppendText("\tset\n\t\t{\n");
                            codigo.AppendText("\t\t\t" + listaAtributos[i].Split(' ')[1] + " = value;\n\t\t}\n\t}\n");
                        }
                        
                    } 
                    
                }
                // Llave de fin
                codigo.AppendText("}");
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            EliminarTexto(true);  
        }

        private void btnCrearArchivo_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("ClasesCreadas");
            CompruebaNombreClase();

            if (codigo.Text == "")
            {
                AnyadirError("");
            }

            if (!RevisaError())
            {
                StreamWriter archivo = File.CreateText(@"ClasesCreadas\" + nombreClase.Text + ".cs");
                archivo.Write(codigo.Text.ToString());
                archivo.Close();
                MessageBox.Show("Class " + nombreClase.Text + ".cs was created!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EliminarTexto(bool pregunta)
        {
            if (pregunta)
            {
                if (MessageBox.Show("Wish you delete preview?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    codigo.Clear();
            }

            codigo.Clear();
        }

        private void LimpiaErrores()
        {
            errores.RemoveAll(x => true);
        }

        private List<String> AnyadirError(String mensaje)
        {
            errores.Add(mensaje);
            return errores;
        }

        private bool RevisaError()
        {
            bool hayError;
            StringBuilder contenido = new StringBuilder();
            foreach (var error in errores)
            {
                contenido.Append("- " + error + "\n");
            }

            if (errores.Count > 0)
            {
                MessageBox.Show(contenido.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hayError = true;
            }
            else
                hayError = false;

            LimpiaErrores();
            return hayError;
        }

        private bool CompruebaNombreClase()
        {
            if (nombreClase.Text == "")
            {
                AnyadirError("Name class cannot be empty");
                return false;
            }
            else
                return true;
        }

 
    }
}
