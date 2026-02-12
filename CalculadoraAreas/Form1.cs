using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraAreas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InicializarComboBoxes();
        }

        /// <summary>
        /// Inicializa los ComboBoxes con valores predeterminados
        /// </summary>
        private void InicializarComboBoxes()
        {
            // Configurar ComboBox de figuras
            cboFiguras.Items.Clear();
            cboFiguras.Items.Add("Rectángulo");
            cboFiguras.Items.Add("Círculo");
            cboFiguras.Items.Add("Triángulo");
            cboFiguras.Items.Add("Cuadrado");

            // Configurar ComboBox de unidades
            cboUnidades.Items.Clear();
            cboUnidades.Items.Add("cm");
            cboUnidades.Items.Add("m");
            cboUnidades.Items.Add("km");
            cboUnidades.Items.Add("in");
            cboUnidades.Items.Add("ft");

            // Seleccionar valores por defecto
            cboUnidades.SelectedIndex = 0; // cm por defecto
        }

        /// <summary>
        /// Evento que se ejecuta cuando se selecciona una figura diferente
        /// Muestra/oculta campos según la figura seleccionada
        /// </summary>
        private void cboFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ocultar todos los controles primero
            OcultarTodosLosParametros();

            // Mostrar controles según la figura seleccionada
            switch (cboFiguras.SelectedIndex)
            {
                case 0: // Rectángulo
                    MostrarParametrosRectangulo();
                    break;
                case 1: // Círculo
                    MostrarParametrosCirculo();
                    break;
                case 2: // Triángulo
                    MostrarParametrosTriangulo();
                    break;
                case 3: // Cuadrado
                    MostrarParametrosCuadrado();
                    break;
            }

            // Ocultar resultados cuando se cambia de figura
            gbResultados.Visible = false;
        }

        /// <summary>
        /// Oculta todos los parámetros de entrada
        /// </summary>
        private void OcultarTodosLosParametros()
        {
            lbl1.Visible = false;
            txt1.Visible = false;
            lbl2.Visible = false;
            txt2.Visible = false;
            lbl3.Visible = false;
            txt3.Visible = false;
            lbl4.Visible = false;
            txt4.Visible = false;
        }

        /// <summary>
        /// Muestra los parámetros necesarios para un rectángulo
        /// </summary>
        private void MostrarParametrosRectangulo()
        {
            lbl1.Text = "Base:";
            lbl1.Visible = true;
            txt1.Visible = true;

            lbl2.Text = "Altura:";
            lbl2.Visible = true;
            txt2.Visible = true;
        }

        /// <summary>
        /// Muestra los parámetros necesarios para un círculo
        /// </summary>
        private void MostrarParametrosCirculo()
        {
            lbl1.Text = "Radio:";
            lbl1.Visible = true;
            txt1.Visible = true;
        }

        /// <summary>
        /// Muestra los parámetros necesarios para un triángulo
        /// </summary>
        private void MostrarParametrosTriangulo()
        {
            lbl1.Text = "Base:";
            lbl1.Visible = true;
            txt1.Visible = true;

            lbl2.Text = "Altura:";
            lbl2.Visible = true;
            txt2.Visible = true;

            lbl3.Text = "Lado 1:";
            lbl3.Visible = true;
            txt3.Visible = true;

            lbl4.Text = "Lado 2:";
            lbl4.Visible = true;
            txt4.Visible = true;

            // Nota: El lado 3 se calcula como la base para simplificar
        }

        /// <summary>
        /// Muestra los parámetros necesarios para un cuadrado
        /// </summary>
        private void MostrarParametrosCuadrado()
        {
            lbl1.Text = "Lado:";
            lbl1.Visible = true;
            txt1.Visible = true;
        }

        /// <summary>
        /// Evento del botón Calcular
        /// Crea la figura correspondiente y calcula área y perímetro
        /// </summary>
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se haya seleccionado una figura
                if (cboFiguras.SelectedIndex == -1)
                {
                    MostrarError("Por favor, seleccione una figura geométrica.");
                    return;
                }

                // Validar que se haya seleccionado una unidad
                if (cboUnidades.SelectedIndex == -1)
                {
                    MostrarError("Por favor, seleccione una unidad de medida.");
                    return;
                }

                string unidad = cboUnidades.SelectedItem.ToString();
                FiguraGeometrica figura = null;

                // Crear la figura según la selección (Polimorfismo en acción)
                switch (cboFiguras.SelectedIndex)
                {
                    case 0: // Rectángulo
                        figura = CrearRectangulo(unidad);
                        break;
                    case 1: // Círculo
                        figura = CrearCirculo(unidad);
                        break;
                    case 2: // Triángulo
                        figura = CrearTriangulo(unidad);
                        break;
                    case 3: // Cuadrado
                        figura = CrearCuadrado(unidad);
                        break;
                }

                // Calcular y mostrar resultados
                if (figura != null)
                {
                    MostrarResultados(figura);
                }
            }
            catch (FormatException)
            {
                MostrarError("Por favor, ingrese valores numéricos válidos.");
            }
            catch (ArgumentException ex)
            {
                MostrarError(ex.Message);
            }
            catch (Exception ex)
            {
                MostrarError($"Error inesperado: {ex.Message}");
            }
        }

        /// <summary>
        /// Crea un objeto Rectángulo con los valores ingresados
        /// </summary>
        private Rectangulo CrearRectangulo(string unidad)
        {
            double baseRect = ObtenerValorDouble(txt1, "base");
            double altura = ObtenerValorDouble(txt2, "altura");
            return new Rectangulo(baseRect, altura, unidad);
        }

        /// <summary>
        /// Crea un objeto Círculo con los valores ingresados
        /// </summary>
        private Circulo CrearCirculo(string unidad)
        {
            double radio = ObtenerValorDouble(txt1, "radio");
            return new Circulo(radio, unidad);
        }

        /// <summary>
        /// Crea un objeto Triángulo con los valores ingresados
        /// </summary>
        private Triangulo CrearTriangulo(string unidad)
        {
            double baseTriang = ObtenerValorDouble(txt1, "base");
            double altura = ObtenerValorDouble(txt2, "altura");
            double lado1 = ObtenerValorDouble(txt3, "lado 1");
            double lado2 = ObtenerValorDouble(txt4, "lado 2");
            // El lado3 es igual a la base en este caso
            double lado3 = baseTriang;

            return new Triangulo(baseTriang, altura, lado1, lado2, lado3, unidad);
        }

        /// <summary>
        /// Crea un objeto Cuadrado con los valores ingresados
        /// </summary>
        private Cuadrado CrearCuadrado(string unidad)
        {
            double lado = ObtenerValorDouble(txt1, "lado");
            return new Cuadrado(lado, unidad);
        }

        /// <summary>
        /// Obtiene y valida un valor double de un TextBox
        /// </summary>
        private double ObtenerValorDouble(TextBox textBox, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                throw new ArgumentException($"El campo {nombreCampo} no puede estar vacío.");
            }

            if (!double.TryParse(textBox.Text, out double valor))
            {
                throw new FormatException($"El valor ingresado en {nombreCampo} no es válido.");
            }

            return valor;
        }

        /// <summary>
        /// Muestra los resultados de los cálculos
        /// Demuestra el uso de polimorfismo
        /// </summary>
        private void MostrarResultados(FiguraGeometrica figura)
        {
            // Calcular área y perímetro (polimorfismo - se ejecuta el método de la clase específica)
            double area = figura.CalcularArea();
            double perimetro = figura.CalcularPerimetro();
            string unidad = figura.UnidadMedida;

            // Actualizar labels con resultados
            lblDescripcion.Text = figura.ObtenerDescripcion();
            lblDescripcion.ForeColor = Color.DarkSlateGray;

            lblResultadoArea.Text = $"Área: {area:F2} {unidad}²";
            lblResultadoArea.ForeColor = Color.DarkGreen;

            lblResultadoPerimetro.Text = $"Perímetro: {perimetro:F2} {unidad}";
            lblResultadoPerimetro.ForeColor = Color.DarkBlue;

            // Mostrar el panel de resultados
            gbResultados.Visible = true;
        }

        /// <summary>
        /// Muestra un mensaje de error al usuario
        /// </summary>
        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error de Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Evento del botón Limpiar
        /// Reinicia todos los campos del formulario
        /// </summary>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar ComboBoxes
            cboFiguras.SelectedIndex = -1;
            cboUnidades.SelectedIndex = 0; // Volver a cm

            // Limpiar TextBoxes
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();

            // Ocultar todos los parámetros
            OcultarTodosLosParametros();

            // Ocultar resultados
            gbResultados.Visible = false;

            // Establecer foco en el ComboBox de figuras
            cboFiguras.Focus();
        }
    }
}
