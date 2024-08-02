
using EjercicioAbstraccion;

Operaciones operaciones = new Operaciones();
Console.WriteLine("Ingrese el valor de la hipotenusa");
bool validhipotenusa = double.TryParse(Console.ReadLine(), out operaciones.hipotenusa);

Console.WriteLine("Ingrese el valor del cateto opuesto");
bool validcatetoOpuesto = double.TryParse(Console.ReadLine(), out operaciones.catetoOpuesto);

Console.WriteLine("Ingrese el valor del cateto continuo");
bool validcatetoContinuo = double.TryParse(Console.ReadLine(), out operaciones.catetoContinuo);

if (validcatetoContinuo  && validcatetoOpuesto && validhipotenusa)
{
    operaciones.Imprimir();
} else
{
    Console.WriteLine("Los valores ingresados son incorrectos");
}

Console.ReadLine();