namespace Examen1.obj.Clases
{
    public class Ejercicio4
    {
        /*Propiedades auto-implementadas ({ get; set; }):
            i. Nombre (string)
            ii. Precio (decimal)
            iii. Stock (int)*/
        public string Nombre{get;set;}
        public decimal Precio{get; set;}
        public int Stock{get;set;}
        public Ejercicio4(string nombre="Clavos",decimal precio =5, int stock=1000)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;

            

        }
    }
}