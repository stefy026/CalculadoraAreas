using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAreas
{
    /// <summary>
    /// Clase abstracta base que define la estructura común para todas las figuras geométricas.
    /// Implementa el principio de abstracción de POO.
    /// </summary>
    public abstract class FiguraGeometrica
    {
        // Campos protegidos - pueden ser accedidos por clases derivadas
        protected string nombre;
        protected string unidadMedida;
        protected string descripcion;

        /// <summary>
        /// Constructor de la clase base
        /// </summary>
        /// <param name="nombre">Nombre de la figura geométrica</param>
        /// <param name="unidadMedida">Unidad de medida (cm, m, km, in, ft)</param>
        public FiguraGeometrica(string nombre, string unidadMedida)
        {
            this.nombre = nombre;
            this.unidadMedida = unidadMedida;
            this.descripcion = "";
        }

        // Propiedades públicas con encapsulamiento
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string UnidadMedida
        {
            get { return unidadMedida; }
            set { unidadMedida = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        /// <summary>
        /// Método abstracto para calcular el área.
        /// Debe ser implementado por todas las clases derivadas.
        /// </summary>
        /// <returns>Área de la figura</returns>
        public abstract double CalcularArea();

        /// <summary>
        /// Método abstracto para calcular el perímetro.
        /// Debe ser implementado por todas las clases derivadas.
        /// </summary>
        /// <returns>Perímetro de la figura</returns>
        public abstract double CalcularPerimetro();

        /// <summary>
        /// Método virtual que puede ser sobrescrito por clases derivadas.
        /// Proporciona una descripción básica de la figura.
        /// </summary>
        /// <returns>Descripción de la figura</returns>
        public virtual string ObtenerDescripcion()
        {
            return $"Figura: {nombre} | Unidad: {unidadMedida}";
        }

        /// <summary>
        /// Método auxiliar para formatear resultados numéricos
        /// </summary>
        /// <param name="valor">Valor a formatear</param>
        /// <returns>Valor formateado con 2 decimales</returns>
        protected string FormatearResultado(double valor)
        {
            return valor.ToString("F2");
        }
    }
}
