
namespace CalcularSalario.Calcular
{
    public class Calcular
    {
        public void CalcularSalario()
        {
            int horasTrabajadas = 0;
            int CostoHora = 0;
            decimal sueldo = 0;

            Console.WriteLine("Digite la cantidad de horas: ");
            horasTrabajadas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el costo por hora:");
            CostoHora = Convert.ToInt32(Console.ReadLine());

            sueldo = (horasTrabajadas * CostoHora);
            Console.WriteLine($"El sueldo es: { sueldo }");
        }


        public void CalcularProductoSuma()
        {
            int num1 = 0;
            int num2 = 0;
            int suma = 0;
            int producto = 0;


            Console.WriteLine("Digite el primer numero entero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el seguno numero entero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            suma = (num1 + num2);
            producto = (num1 * num2);

            Console.WriteLine($"Resultado de la suma: { suma }");
            Console.WriteLine($"Resultado del producto: { producto }");

        }
    }
}
