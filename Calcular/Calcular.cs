﻿
namespace CalcularSalario.Calcular
{
    public class Calcular
    {
        public void CalcularSalario()
        {
            int horasTrabajadas = 0;
            int CostoHora = 0;
            decimal sueldo = 0;
            decimal impuesto = 0.18m;
            decimal valorImpuesto = 0;


            try
            {
                Console.WriteLine("Digite la cantidad de horas: ");
                horasTrabajadas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el costo por hora:");
                CostoHora = Convert.ToInt32(Console.ReadLine());

                sueldo = (horasTrabajadas * CostoHora);

                Console.WriteLine($"El sueldo antes de impuestos es: {sueldo}");
                if (sueldo > 3000)
                {

                }
                               
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió el siguiente error: { ex.Message } calculando el sueldo ");
            }

        }


        public void CalcularProductoSuma()
        {
            int num1 = 0;
            int num2 = 0;
            int suma = 0;
            int producto = 0;


            Console.WriteLine("Digite el primer número entero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el segundo número entero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            suma = (num1 + num2);
            producto = (num1 * num2);

            Console.WriteLine($"Resultado de la suma: { suma }");
            Console.WriteLine($"Resultado del producto: { producto }");

        }
    }
}
