namespace Examen1.obj.Clases
{
    public class Ejercicio2
    {
            public Ejercicio2()
            {
                /*i. 1. Declare una variable saldo de tipo decimal con cualquier valor de prueba.
                ii. 2. Use una estructura if / else if / else para determinar la categoría.
                iii. 3. Declare una variable categoría de tipo string que almacene el resultado.
                iv. 4. Muestre en consola (usando interpolación de strings):
                Saldo: L. 7,500.00
                Categoría asignada: Oro
                ¡Felicidades! Accede a tasas preferenciales.*/

                Console.WriteLine("Por favor ingrese el saldo en su cuenta de ahorros:");
                decimal.TryParse(Console.ReadLine(),out decimal saldo);
                string categoria;
                string mensaje;
                if(saldo<1000)
                {
                    categoria = "Basico";
                    mensaje = "Abra un CDT para mejorar su categoría.";
                }
                else if(saldo<5000)
                {
                    categoria = "Plata";
                    mensaje = "Tiene acceso a tarjeta de débito sin comisión.";
                }
                else if(saldo<20000)
                {
                    categoria = "Oro";
                    mensaje = "¡Felicidades! Accede a tasas preferenciales.";
                }
                else
                {
                    categoria = "Platino";
                    mensaje = "¡Cliente VIP! Accede a todos los beneficios del banco.";
                }

                Console.WriteLine($"Saldo : L {saldo}");
                Console.WriteLine($"Categoría asignada : {categoria}");
                Console.WriteLine($"{mensaje}");

            }
        
    }
}
