using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAreas
{
    /// <summary>
    /// Clase que representa un cuadrado.
    /// Hereda de FiguraGeometrica e implementa los métodos abstractos.
    /// </summary>
    public class Cuadrado : FiguraGeometrica
    {
        // Campo privado específico del cuadrado
        private double lado;

        /// <summary>
        /// Constructor del cuadrado
        /// </summary>
        /// <param name="lado">Lado del cuadrado</param>
        /// <param name="unidadMedida">Unidad de medida</param>
        public Cuadrado(double lado, string unidadMedida)
            : base("Cuadrado", unidadMedida)
        {
            ValidarParametro(lado);
            this.lado = lado;
            ActualizarDescripcion();
        }

        // Propiedad con validación
        public double Lado
        {
            get { return lado; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El lado debe ser mayor que cero.");
                lado = value;
                ActualizarDescripcion();
            }
        }

        /// <summary>
        /// Valida que el parámetro sea válido
        /// </summary>
        private void ValidarParametro(double lado)
        {
            if (lado <= 0)
                throw new ArgumentException("El lado debe ser un valor positivo.");
        }

        /// <summary>
        /// Calcula el área del cuadrado
        /// Fórmula: Área = lado²
        /// </summary>
        public override double CalcularArea()
        {
            return Math.Pow(lado, 2);
        }

        /// <summary>
        /// Calcula el perímetro del cuadrado
        /// Fórmula: Perímetro = 4 × lado
        /// </summary>
        public override double CalcularPerimetro()
        {
            return 4 * lado;
        }

        /// <summary>
        /// Sobrescribe el método para proporcionar descripción específica
        /// </summary>
        public override string ObtenerDescripcion()
        {
            return descripcion;
        }

        /// <summary>
        /// Actualiza la descripción del cuadrado
        /// </summary>
        private void ActualizarDescripcion()
        {
            descripcion = $"Cuadrado con lado = {FormatearResultado(lado)} {unidadMedida}";
        }

        /// <summary>
        /// Calcula la diagonal del cuadrado (método adicional útil)
        /// Fórmula: Diagonal = lado × √2
        /// </summary>
        /// <returns>Diagonal del cuadrado</returns>
        public double CalcularDiagonal()
        {
            return lado * Math.Sqrt(2);
        }
    }
}
