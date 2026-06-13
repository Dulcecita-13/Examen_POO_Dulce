namespace Examen1.obj.Clases
{
    public class Ejercicio1
    {
        /*Declare las siguientes variables con los tipos de dato apropiados: 
        i. nombreProducto con valor "Fertilizante NPK" 
        ii. precioPorKg con valor 35.75 — use el tipo 
        apropiado para representar dinero con precisión exacta.
        iii. cantidadKg con valor 12 (entero)
        iv. descuentoPorcentaje con valor 10*/

        public Ejercicio1()
        {
            string nombreProducto="Fertilizante NPK";
            float precioPorKg = 35.75f;
            int cantidadKg=12;
            int descuentoPorcentaje = 10; 

            /*b. Calcule y almacene en variables: 
            i. subtotal = precioPorKg * cantidadKg
            ii. descuento = subtotal * descuentoPorcentaje / 100
            iii. totalFinal = subtotal - descuento*/

            float subtotal = precioPorKg*cantidadKg;
            float descuento = subtotal*(descuentoPorcentaje/100);
            float totalFinal = subtotal - descuento;
            /*Muestre en consola el siguiente resumen usando interpolación de strings ($"..."):
            === FACTURA AGROCOPRÁN ===
            Producto : Fertilizante NPK
            Cantidad : 12 kg
            Precio/kg : L. 35.75
            Subtotal : L. 429.00
            Descuento : L. 42.90
            Total : L. 386.10*/

            Console.WriteLine("=== FACTURA AGROCOPÁN ===");
            Console.WriteLine($"Producto : {nombreProducto}");
            Console.WriteLine($"Cantidad : {cantidadKg} kg");
            Console.WriteLine($"Precio/kg : L {precioPorKg} ");
            Console.WriteLine($"Subtotal : L {subtotal}");
            Console.WriteLine($"Descuento : L {descuento}");
            Console.WriteLine($"Total : L {totalFinal}");

        }
    }
}