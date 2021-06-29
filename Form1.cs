using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Procesamiento_por_lotes
{
    public partial class Form1 : Form
    {
        Proceso ProcesoActual = null;
        int segundos = 0;
        int contProceso = 0;
        int conteoRestante = 0;
        int loteActual = 1;
        int numeloteActual = 1;
        int cantidadProcesos= 0;
        //Arrays de procesos
       public ArrayList procesos = new ArrayList();
       public ArrayList procesosTerminados = new ArrayList();
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numlote.Text = numeloteActual.ToString( );
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }
        private Form activeform = null;
        private void openChildForm(Form childForm)
        {
            if (activeform != null)
            {
                activeform.Close();

            }


        }

        #region ControlVentana
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region IDTextBox
        private void id_tb_Enter(object sender, EventArgs e)
        {
            if (id_tb.Text == "ID") 
            {
                id_tb.Text = "";
                id_tb.ForeColor = Color.DodgerBlue;
;            }
        }

        private void id_tb_Leave(object sender, EventArgs e)
        {
            if (id_tb.Text == "") 
            {
                id_tb.Text = "ID";
                id_tb.ForeColor = Color.Silver;
            }
        }

        private void id_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region TiempoTextBox
        private void tiempo_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tiempo_tb_Enter(object sender, EventArgs e)
        {
            if (tiempo_tb.Text == "Tiempo Estimado") 
            {
                tiempo_tb.Text = "";
                tiempo_tb.ForeColor = Color.DodgerBlue;
            }
        }

        private void tiempo_tb_Leave(object sender, EventArgs e)
        {
            if (tiempo_tb.Text == "") 
            {
                tiempo_tb.Text = "Tiempo Estimado";
                tiempo_tb.ForeColor = Color.Silver;
            
            }
        }




        #endregion

        #region NombreTextBox
        private void nombre_tb_Enter(object sender, EventArgs e)
        {
            if(nombre_tb.Text == "Nombre") 
            {
                nombre_tb.Text = "";
                nombre_tb.ForeColor = Color.DodgerBlue;

            
            }
        }

        private void nombre_tb_Leave(object sender, EventArgs e)
        {
            if (nombre_tb.Text == "") 
            {
                nombre_tb.Text = "Nombre";
                nombre_tb.ForeColor = Color.Silver;
            }
        }

        #endregion

        #region 1rerNumTextBox
        private void primerNum_Enter(object sender, EventArgs e)
        {
            if (primerNum.Text == "--")
            {
                primerNum.Text = "";
                primerNum.ForeColor = Color.DodgerBlue;
            }
        }

        private void primerNum_Leave(object sender, EventArgs e)
        {
            if (primerNum.Text == "") 
            {
                primerNum.Text = "--";
                primerNum.ForeColor = Color.Silver;
            
            }
        }

        private void primerNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region 2doNumTextBox
        private void segundoNum_Enter(object sender, EventArgs e)
        {
            if (segundoNum.Text == "--")
            {
                segundoNum.Text = "";
                segundoNum.ForeColor = Color.DodgerBlue;
            }
        }

        private void segundoNum_Leave(object sender, EventArgs e)
        {
            if (segundoNum.Text == "")
            {
                segundoNum.Text = "--";
                segundoNum.ForeColor = Color.Silver;

            }
        }

        private void segundoNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion


        //Metodo del boton Agregar
        private void agregar_Click(object sender, EventArgs e)
        {
            //Boleanos de validacion
            bool registro = true;
            bool tiempoCoherente = true;
            bool divisorCorrecto = true;
            bool camposLlenos = true;
            
            //Separamos los lotes en 5
            if (cantidadProcesos >= 5) 
            {
                numeloteActual++;
                cantidadProcesos = 0;
            }
            numlote.Text = numeloteActual.ToString();

            //Validamos que no se repitan ID
            foreach (Proceso p in procesos) 
            {
                if(id_tb.Text == p.id) 
                {
                    
                    registro = false;
                }
            
            }
            //Validamos tiempo,Division y que todos los campos se llenen
            if (tiempo_tb.Text != "Tiempo Estimado")
            {
                if (System.Convert.ToInt32(tiempo_tb.Text) <= 0)
                    tiempoCoherente = false;
            }

            if (segundoNum.Text != "--" )
            {
                if (System.Convert.ToInt32(segundoNum.Text) == 0 && (operando.Text == "/" || operando.Text == "%"))
                    divisorCorrecto = false;
            }

            if (id_tb.Text == "ID" || nombre_tb.Text == "Nombre" || primerNum.Text == "--" || segundoNum.Text == "--" || tiempo_tb.Text == "Tiempo Estimado" || operando.Text == "")
                camposLlenos = false;

            //Si todo esta correcto podemos agragarlo
            if(registro == true && camposLlenos ==true && divisorCorrecto == true && tiempoCoherente == true) 
            {
                Proceso addprocces = new Proceso();
                addprocces.numerolote = numlote.Text;
                addprocces.id = id_tb.Text;
                addprocces.nombre = nombre_tb.Text;
                addprocces.numero1 = System.Convert.ToInt32(primerNum.Text);
                addprocces.numero2 = System.Convert.ToInt32(segundoNum.Text);
                addprocces.tiempo = System.Convert.ToInt32(tiempo_tb.Text);
                addprocces.tdo = operando.Text;
                addprocces.operacion = primerNum.Text + operando.Text + segundoNum.Text;
                addprocces.resultado = System.Convert.ToInt32(primerNum.Text) +System.Convert.ToInt32( segundoNum.Text);
                procesos.Add(addprocces);
                cantidadProcesos++;
                //Funcion listar para desplegarlos en la tabla
                listar(registroTabla,procesos);
            }

            //Mesajes de error 
            else if(registro == false)
                MessageBox.Show("IVerifique que la ID que haya ingresado no este en uso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(camposLlenos == false)
                MessageBox.Show("Verifique haber llenado todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (divisorCorrecto == false)
                MessageBox.Show("No se puede dividir entre 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (tiempoCoherente == false)
                MessageBox.Show("El tiempo no puede ser 0 ni un valor negativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public void listar( ListView listView, ArrayList array)
        {
            listView.Items.Clear();
            foreach(Proceso pros in array) 
            {
                ListViewItem fila = new ListViewItem(pros.numerolote);
                fila.SubItems.Add(pros.id);
                fila.SubItems.Add(pros.nombre);
                fila.SubItems.Add(pros.tiempo.ToString());
                fila.SubItems.Add(pros.operacion);

                listView.Items.Add(fila);
            
            }

        }

        public void listarCompletos(ListView listView, ArrayList array)
        {
            listView.Items.Clear();
            foreach (Proceso pros in array)
            {
                ListViewItem fila = new ListViewItem(pros.numerolote);
                fila.SubItems.Add(pros.id);
                fila.SubItems.Add(pros.nombre);
                fila.SubItems.Add(pros.tiempo.ToString());
                fila.SubItems.Add(pros.operacion);
                fila.SubItems.Add(pros.resultado.ToString());

                listView.Items.Add(fila);

            }

        }

        private void listarLotes(ListView listView, ArrayList array, int lotelista)
        {
            listView.Items.Clear();
            foreach (Proceso pros in array)
            {
                if (System.Convert.ToInt32(pros.numerolote) == lotelista)
                {
                    ListViewItem fila = new ListViewItem(pros.numerolote);
                    fila.SubItems.Add(pros.id);
                    fila.SubItems.Add(pros.nombre);
                    fila.SubItems.Add(pros.tiempo.ToString());
                    fila.SubItems.Add(pros.operacion);

                    listView.Items.Add(fila);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (procesos.Count >= 1)
            {
                agregar.Enabled = false;
                button1.Enabled = false;

                tabControl1.SelectedTab = ejecucion;
                Conteo.Enabled = true;
                tiempoProceso.Enabled = true;
            }
            else
                MessageBox.Show("No hay procesos en cola", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tiempoProceso_Tick(object sender, EventArgs e)
        {
            

            if (procesos.Count <=0)
            {
                tbTiempo.Text = "";
                tbID.Text = "";
                tbNom.Text = "";
                tbOp.Text = "";
                tiempoProceso.Enabled = false;


            }
            contProceso++;
            if (procesos.Count > 0)
            {
                segundos++;
            }

            listarLotes(Pendientes, procesos, loteActual);
        }

        private void Conteo_Tick(object sender, EventArgs e)
        {
            
            if (procesos.Count <= 0)
            {
                Conteo.Enabled = false;
            }

            else 
                ProcesoActual = (Proceso)procesos[0];
  
            listarLotes(Pendientes, procesos, loteActual);

            tbTiempo.Text = (ProcesoActual.tiempo - contProceso).ToString();
            tbID.Text = ProcesoActual.id;
            tbNom.Text = ProcesoActual.nombre;
            tbOp.Text = ProcesoActual.nombre;
         
            switch (ProcesoActual.tdo.ToString()) 
            {
                case "+":
                    ProcesoActual.resultado = System.Convert.ToInt32(ProcesoActual.numero1) + System.Convert.ToInt32(ProcesoActual.numero2);
                    break;
                case "-":
                    ProcesoActual.resultado = System.Convert.ToInt32(ProcesoActual.numero1) - System.Convert.ToInt32(ProcesoActual.numero2);
                    break;
                case "/":
                    ProcesoActual.resultado = System.Convert.ToInt32(ProcesoActual.numero1) / System.Convert.ToInt32(ProcesoActual.numero2);
                    break;
                case "X":
                    ProcesoActual.resultado = System.Convert.ToInt32(ProcesoActual.numero1) * System.Convert.ToInt32(ProcesoActual.numero2);
                    break;
                case "%":
                    ProcesoActual.resultado = System.Convert.ToInt32(ProcesoActual.numero1) %  System.Convert.ToInt32(ProcesoActual.numero2);
                    break;

            }
           

            if (tbID.Text == ProcesoActual.id && Pendientes.Items.Count >0)
                Pendientes.Items.RemoveAt(0);

            if(contProceso == ProcesoActual.tiempo )
            {
                procesosTerminados.Add(ProcesoActual);
                if(procesos.Count >= 0)
                    procesos.RemoveAt(0);
                contProceso = 0;
                tbTiempo.Text = "";
                tbID.Text = "";
                tbNom.Text = "";
                tbOp.Text = "";

            }

            if (Pendientes.Items.Count == 0)
                loteActual++;

            if(procesosTerminados.Count > 0)
                listarCompletos(tablaCompletados, procesosTerminados);

            tbTiempoTr.Text = segundos.ToString();

            if (procesos.Count == 0) 
            {
                tbTiempo.Text = "";
                tbID.Text = "";
                tbNom.Text = "";
                tbOp.Text = "";
            }
            loteActual_.Text = numeloteActual.ToString();
        }


    }
}
