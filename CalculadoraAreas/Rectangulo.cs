using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAreas
{
    /// <summary>
    /// Clase que representa un rectángulo.
    /// Hereda de FiguraGeometrica e implementa los métodos abstractos.
    /// </summary>
    public class Rectangulo : FiguraGeometrica
    {
        // Campos privados específicos del rectángulo
        private double baseRectangulo;
        private double altura;

        /// <summary>
        /// Constructor del rectángulo
        /// </summary>
        /// <param name="baseRect">Base del rectángulo</param>
        /// <param name="altura">Altura del rectángulo</param>
        /// <param name="unidadMedida">Unidad de medida</param>
        public Rectangulo(double baseRect, double altura, string unidadMedida)
            : base("Rectángulo", unidadMedida)
        {
            ValidarParametros(baseRect, altura);
            this.baseRectangulo = baseRect;
            this.altura = altura;
            ActualizarDescripcion();
        }

        // Propiedades con validación
        public double Base
        {
            get { return baseRectangulo; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La base debe ser mayor que cero.");
                baseRectangulo = value;
                ActualizarDescripcion();
            }
        }

        public double Altura
        {
            get { return altura; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La altura debe ser mayor que cero.");
                altura = value;
                ActualizarDescripcion();
            }
        }

        /// <summary>
        /// Valida que los parámetros sean válidos
        /// </summary>
        private void ValidarParametros(double baseRect, double altura)
        {
            if (baseRect <= 0)
                throw new ArgumentException("La base debe ser un valor positivo.");
            if (altura <= 0)
                throw new ArgumentException("La altura debe ser un valor positivo.");
        }

        /// <summary>
        /// Calcula el área del rectángulo
        /// Fórmula: Área = base × altura
        /// </summary>
        public override double CalcularArea()
        {
            return baseRectangulo * altura;
        }

        /// <summary>
        /// Calcula el perímetro del rectángulo
        /// Fórmula: Perímetro = 2 × (base + altura)
        /// </summary>
        public override double CalcularPerimetro()
        {
            return 2 * (baseRectangulo + altura);
        }

        /// <summary>
        /// Sobrescribe el método para proporcionar descripción específica
        /// </summary>
        public override string ObtenerDescripcion()
        {
            return descripcion;
        }

        /// <summary>
        /// Actualiza la descripción del rectángulo
        /// </summary>
        private void ActualizarDescripcion()
        {
            descripcion = $"Rectángulo con base = {FormatearResultado(baseRectangulo)} {unidadMedida} " +
                         $"y altura = {FormatearResultado(altura)} {unidadMedida}";
        }
    }
}
