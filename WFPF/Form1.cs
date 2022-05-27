using DataBase.Clases.entidades;
using DataBase.Clases.Servicio;

namespace WFPF
{
    public partial class Form1 : Form
    {
        ClsServicioAlumno srvAlumno = new();
        MdAlumnos oAlumnos = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void DesplegarGrid()
        {
            var respuesta = srvAlumno.ConsultaSQL("Select * from tb_alumnos");
            dataGridViewAlumnos.DataSource = respuesta;
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            DesplegarGrid();
        }

        private void MapaoDatosFormulario(MdAlumnos _alumnos)
        {
            textBoxCarnet.Text = _alumnos.carnet;
            textBoxNombre.Text = _alumnos.nombre;
            textBoxCorreo.Text = _alumnos.correo;
            comboBoxClase.Text = _alumnos.clase;
            comboBoxSeccion.Text = _alumnos.seccion;
            textBoxparcial1.Text = Convert.ToString(_alumnos.parcial1);
            textBoxparcial2.Text = Convert.ToString(_alumnos.parcial2);
            textBoxparcial3.Text = Convert.ToString(_alumnos.parcial3);
        }

        private void LimpiarDatos()
        {
            oAlumnos = new();
            MapaoDatosFormulario(oAlumnos);
        }

        private void buscaAlumno(string carnet)
        {
            oAlumnos = null;
            oAlumnos = srvAlumno.ObtenerAlumno(carnet);
            if (oAlumnos == null)
            {
                MessageBox.Show("El estudiante no existe!");
                LimpiarDatos();
            }
            else
            {
                MapaoDatosFormulario(oAlumnos);
            }
        }
     
        private void buttonConsulta_Click_1(object sender, EventArgs e)
        {
            string carnet = textBoxCarnet.Text;
            buscaAlumno(carnet);
        }
        private MdAlumnos DatosFormulario()
        {
            try
            {   
            MdAlumnos _alumnos = new();
               
                    _alumnos.carnet = textBoxCarnet.Text.Trim();
                    _alumnos.nombre = textBoxNombre.Text.Trim();
                    _alumnos.correo = textBoxCorreo.Text.Trim();
                    _alumnos.clase = comboBoxClase.Text;
                    _alumnos.seccion = comboBoxSeccion.Text;
                    if ((_alumnos.parcial1 = int.Parse(textBoxparcial1.Text)) <= 20)
                    {
                        _alumnos.parcial1 = int.Parse(textBoxparcial1.Text);
                    }
                    else
                    {
                        _alumnos.parcial1 = 0;
                        MessageBox.Show("No se pueden ingresar notas mayores a 20", "Parcial 1");
                    }
                    if ((_alumnos.parcial2 = int.Parse(textBoxparcial2.Text)) <= 20)
                    {
                        _alumnos.parcial2 = int.Parse(textBoxparcial2.Text);
                    }
                    else
                    {
                        _alumnos.parcial2 = 0;
                        MessageBox.Show("No se pueden ingresar notas mayores a 20", "Parcial 2");
                    }
                    if ((_alumnos.parcial3 = int.Parse(textBoxparcial3.Text)) <= 35)
                    {
                        _alumnos.parcial3 = int.Parse(textBoxparcial3.Text);
                    }
                    else
                    {
                        _alumnos.parcial3 = 0;
                        MessageBox.Show("No se pueden ingresar notas mayores a 35", "Parcial 3");
                    }
                    return _alumnos;
               


            }
            catch (Exception ex)
            {

                return null;
            }
            

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (oAlumnos.nombre != null)
            {

                oAlumnos = DatosFormulario();
                int respuesta = srvAlumno.actualizarAlumno(oAlumnos);

                if (respuesta > 0)
                {
                    MessageBox.Show("Se Actualizo el Alumno");
                    LimpiarDatos();
                    DesplegarGrid();
                }
                else
                {
                    MessageBox.Show("Hubo un problema para actualizar alumno");
                }
            }
            else
            {
                MessageBox.Show("No se puede dejar la casilla Nombre en blanco", "Error");
            }
        }

        private void buttonCrearAlumno_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != "") 
            {
                oAlumnos = DatosFormulario();
                int respuesta = srvAlumno.CrearAlumno(oAlumnos);

                if (respuesta > 0)
                {
                    MessageBox.Show("Alumno creado con exito!");
                    LimpiarDatos();
                    DesplegarGrid();
                }
                else
                {
                    MessageBox.Show("Perdon, hubo un problema para crear el alumno");
                }
            }
            else
            {
                MessageBox.Show("No se puede dejar la casilla Nombre en blanco", "Error");
            }
        }

        private void buttonImportar_Click(object sender, EventArgs e)
        {
            string archivo = @"C:\Users\alumno\Documents\tb_alumnos_temp.txt";
            ClsImportExport im = new();
            MessageBox.Show(im.importar(archivo));
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            string archivo = @"C:\Users\alumno\Documents\Salida.csv";
            ClsImportExport im = new();
            MessageBox.Show(im.exportar("select * from tb_alumnos where seccion='A'", archivo));
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas seguro que quieres eliminar a este alumno?", "Eliminar Alumno", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                oAlumnos = DatosFormulario();
                int respuesta = srvAlumno.BorrarAlumno(oAlumnos);

                if (respuesta > 0)
                {
                    MessageBox.Show("Alumno eliminado exitosamente");
                    LimpiarDatos();
                    DesplegarGrid();
                }
                else
                {
                    MessageBox.Show("Hubo un problema al eliminar el alumno");
                }

            }
            if (r== DialogResult.No)
            {
                LimpiarDatos();
            }
            

        }
    }
}