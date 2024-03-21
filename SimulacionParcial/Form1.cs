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

namespace SimulacionParcial
{
    public partial class Form1 : Form
    {
        List<Departamentos> departamentoslista = new List<Departamentos>();
        List<DatosDepartamentos> datosdepartamentoslista = new List<DatosDepartamentos>();
        List<Reporte> reportelista = new List<Reporte>();
        public Form1()
        {
            InitializeComponent();
        }




        public void GuardarDepartamentos()
        {
            using (FileStream stream = new FileStream("Departamentos.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    foreach (Departamentos departamentos in departamentoslista)
                    {
                        writer.WriteLine(departamentos.NoIde);
                        writer.WriteLine(departamentos.Nombre);
                    }
                    writer.Close();
                }
            }

        }
        public void MostrarDepartamentos()
        {
            dataGridViewDepartamento.DataSource = null;
            dataGridViewDepartamento.DataSource = departamentoslista;
            dataGridViewDepartamento.Refresh();


        }

        private void btnBotonIngresar_Click(object sender, EventArgs e)
        {
            Departamentos departamentos = new Departamentos();
            departamentos.NoIde = int.Parse(txtNumeroIde.Text);
            departamentos.Nombre = txtDepartamento.Text;
            departamentoslista.Add(departamentos);
            MostrarDepartamentos();
            GuardarDepartamentos();
            
        }


        public void GuardarTemperaturas() 
        {
            using (FileStream stream = new FileStream("DatosDepartamentos.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    foreach (DatosDepartamentos datosDepartamento in datosdepartamentoslista)
                    {
                        writer.WriteLine(datosDepartamento.NoIde);
                        writer.WriteLine(datosDepartamento.Grados);
                    }
                    writer.Close();
                }
            }

        }
        public void MostrarTemperaturas()
        {
            DataGridViewTemperatura.DataSource = null;
            DataGridViewTemperatura.DataSource = departamentoslista;
            DataGridViewTemperatura.Refresh();


        }
        private void btnIngresoTemperatura_Click(object sender, EventArgs e)
        {
            DatosDepartamentos datosdepartamento = new DatosDepartamentos();
            datosdepartamento.NoIde = int.Parse(txtNumeroIde.Text);
            datosdepartamento.Grados = decimal.Parse(txtTemperatura.Text);
            datosdepartamentoslista.Add(datosdepartamento);
            GuardarTemperaturas();
            MostrarTemperaturas();
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            dataGridViewDatos.DataSource = null;
            reportelista.Clear();
            foreach (Departamentos departamentos in departamentoslista)
            {
                DatosDepartamentos datosDepartamentos = datosdepartamentoslista.FirstOrDefault(p => p.NoIde == departamentos.NoIde);
                if (datosDepartamentos != null)
                {
                    Reporte reporte = new Reporte
                    {
                         Nombre = departamentos.Nombre,
                         Grados = datosDepartamentos.Grados,
                    };
                    reportelista.Add(reporte);
                }
            }

            dataGridViewDatos.DataSource = null;
            dataGridViewDatos.DataSource = reportelista;
            dataGridViewDatos.Refresh();

        }

        private void btnOrdenarMayor_Click(object sender, EventArgs e)
        {
            dataGridViewDatos.DataSource = null;
            datosdepartamentoslista = datosdepartamentoslista.OrderBy(p => p.Grados).ToList();
            dataGridViewDatos.DataSource = null;
            dataGridViewDatos.DataSource = datosdepartamentoslista;
            dataGridViewDatos.Refresh();
        }
    }
}
