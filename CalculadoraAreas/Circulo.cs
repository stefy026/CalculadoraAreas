using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAreas
{
    /// <summary>
    /// Clase que representa un círculo.
    /// Hereda de FiguraGeometrica e implementa los métodos abstractos.
    /// </summary>
    public class Circulo : FiguraGeometrica
    {
        // Campo privado específico del círculo
        private double radio;

        /// <summary>
        /// Constructor del círculo
        /// </summary>
        /// <param name="radio">Radio del círculo</param>
        /// <param name="unidadMedida">Unidad de medida</param>
        public Circulo(double radio, string unidadMedida)
            : base("Círculo", unidadMedida)
        {
            ValidarParametro(radio);
            this.radio = radio;
            ActualizarDescripcion();
        }

        // Propiedad con validación
        public double Radio
        {
            get { return radio; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El radio debe ser mayor que cero.");
                radio = value;
                ActualizarDescripcion();
            }
        }

        /// <summary>
        /// Valida que el parámetro sea válido
        /// </summary>
        private void ValidarParametro(double radio)
        {
            if (radio <= 0)
                throw new ArgumentException("El radio debe ser un valor positivo.");
        }

        /// <summary>
        /// Calcula el área del círculo
        /// Fórmula: Área = π × radio²
        /// </summary>
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        /// <summary>
        /// Calcula el perímetro (circunferencia) del círculo
        /// Fórmula: Perímetro = 2 × π × radio
        /// </summary>
        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }

        /// <summary>
        /// Sobrescribe el método para proporcionar descripción específica
        /// </summary>
        public override string ObtenerDescripcion()
        {
            return descripcion;
        }

        /// <summary>
        /// Actualiza la descripción del círculo
        /// </summary>
        private void ActualizarDescripcion()
        {
            descripcion = $"Círculo con radio = {FormatearResultado(radio)} {unidadMedida}";
        }

        /// <summary>
        /// Calcula el diámetro del círculo (método adicional útil)
        /// </summary>
        /// <returns>Diámetro del círculo</returns>
        public double CalcularDiametro()
        {
            return 2 * radio;
        }
    }
}
