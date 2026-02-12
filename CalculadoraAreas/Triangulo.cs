using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAreas
{
    /// <summary>
    /// Clase que representa un triángulo.
    /// Hereda de FiguraGeometrica e implementa los métodos abstractos.
    /// </summary>
    public class Triangulo : FiguraGeometrica
    {
        // Campos privados específicos del triángulo
        private double baseTriangulo;
        private double altura;
        private double lado1;
        private double lado2;
        private double lado3;

        /// <summary>
        /// Constructor del triángulo
        /// </summary>
        /// <param name="baseTriang">Base del triángulo</param>
        /// <param name="altura">Altura del triángulo</param>
        /// <param name="lado1">Primer lado</param>
        /// <param name="lado2">Segundo lado</param>
        /// <param name="lado3">Tercer lado</param>
        /// <param name="unidadMedida">Unidad de medida</param>
        public Triangulo(double baseTriang, double altura, double lado1, double lado2, double lado3, string unidadMedida)
            : base("Triángulo", unidadMedida)
        {
            ValidarParametros(baseTriang, altura, lado1, lado2, lado3);
            this.baseTriangulo = baseTriang;
            this.altura = altura;
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
            ActualizarDescripcion();
        }

        // Propiedades con validación
        public double Base
        {
            get { return baseTriangulo; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La base debe ser mayor que cero.");
                baseTriangulo = value;
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

        public double Lado1
        {
            get { return lado1; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El lado 1 debe ser mayor que cero.");
                lado1 = value;
            }
        }

        public double Lado2
        {
            get { return lado2; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El lado 2 debe ser mayor que cero.");
                lado2 = value;
            }
        }

        public double Lado3
        {
            get { return lado3; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El lado 3 debe ser mayor que cero.");
                lado3 = value;
            }
        }

        /// <summary>
        /// Valida que todos los parámetros sean válidos
        /// </summary>
        private void ValidarParametros(double baseTriang, double altura, double lado1, double lado2, double lado3)
        {
            if (baseTriang <= 0)
                throw new ArgumentException("La base debe ser un valor positivo.");
            if (altura <= 0)
                throw new ArgumentException("La altura debe ser un valor positivo.");
            if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0)
                throw new ArgumentException("Todos los lados deben ser valores positivos.");

            // Validar que los lados formen un triángulo válido (desigualdad triangular)
            if (!EsTrianguloValido(lado1, lado2, lado3))
                throw new ArgumentException("Los lados proporcionados no forman un triángulo válido.");
        }

        /// <summary>
        /// Verifica si tres lados pueden formar un triángulo válido
        /// </summary>
        private bool EsTrianguloValido(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        /// <summary>
        /// Calcula el área del triángulo
        /// Fórmula: Área = (base × altura) / 2
        /// </summary>
        public override double CalcularArea()
        {
            return (baseTriangulo * altura) / 2;
        }

        /// <summary>
        /// Calcula el perímetro del triángulo
        /// Fórmula: Perímetro = lado1 + lado2 + lado3
        /// </summary>
        public override double CalcularPerimetro()
        {
            return lado1 + lado2 + lado3;
        }

        /// <summary>
        /// Sobrescribe el método para proporcionar descripción específica
        /// </summary>
        public override string ObtenerDescripcion()
        {
            return descripcion;
        }

        /// <summary>
        /// Actualiza la descripción del triángulo
        /// </summary>
        private void ActualizarDescripcion()
        {
            descripcion = $"Triángulo con base = {FormatearResultado(baseTriangulo)} {unidadMedida}, " +
                         $"altura = {FormatearResultado(altura)} {unidadMedida}, " +
                         $"lados = {FormatearResultado(lado1)}, {FormatearResultado(lado2)}, {FormatearResultado(lado3)} {unidadMedida}";
        }

        /// <summary>
        /// Determina el tipo de triángulo según sus lados
        /// </summary>
        /// <returns>Tipo de triángulo (Equilátero, Isósceles, Escaleno)</returns>
        public string DeterminarTipo()
        {
            if (lado1 == lado2 && lado2 == lado3)
                return "Equilátero";
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
                return "Isósceles";
            else
                return "Escaleno";
        }
    }
}
