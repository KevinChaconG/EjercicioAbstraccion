

namespace EjercicioAbstraccion
{
    public class Operaciones : Matematicas
    {
        public double catetoOpuesto;
        public double catetoContinuo;
        public double hipotenusa;

        public override double Coseno()
        {
            return catetoContinuo / hipotenusa;
        }

        public override double Seno()
        {
            return catetoOpuesto / hipotenusa;
        }

        public override double Tangente()
        {
            return catetoOpuesto / catetoContinuo;
        }

        public override void Imprimir()
        {
            Console.WriteLine("---Resultados---");
            Console.WriteLine($"Seno: {Seno()}");
            Console.WriteLine($"Coseno: {Coseno()}");
            Console.WriteLine($"Tangente: {Tangente()}");
            Console.WriteLine();
        }
    }
}
