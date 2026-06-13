namespace Examen1.obj.Clases
{
    public class Ejercicio3
    {
        public Ejercicio3()
        {
            Console.WriteLine("Favor de ingresar el número de tabla: ");
            if(!int.TryParse(Console.ReadLine(), out int numero)||numero<=0)
            {
                Console.WriteLine("El número de tabla debe ser mayor a cero.");
                return;
            }
            else
            {
                Console.WriteLine("Favor de ingresar el límite de tabla: ");
                int.TryParse(Console.ReadLine(), out int limite);

                int i;

                for (i=1;i<=limite;i++)
                {
                    Console.WriteLine($"{numero} x {i} = {numero*i}");
                }
            }
         }

    }
}