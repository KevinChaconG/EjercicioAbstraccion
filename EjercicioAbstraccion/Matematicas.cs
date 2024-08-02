

namespace EjercicioAbstraccion
{
    public abstract class Matematicas
    {
        double hipotenusa {  get; set; }
        double catetoOpuesto { get; set; }
        double catetoContiguo { get; set; }

        public abstract void Imprimir();

        public abstract double Seno();
        public abstract double Coseno();
        public abstract double Tangente();

    }
}
