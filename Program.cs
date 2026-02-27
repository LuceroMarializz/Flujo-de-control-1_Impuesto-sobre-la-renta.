namespace Flujo_de_control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SUELDO DE EMPLEADO: ");

            string empl;
            double sueldo;
            double ISR = 0;
            double suel_Anu;

            Console.WriteLine("INGRESE EL NOMBRE DEL EMPLEADO: ");
            empl = Console.ReadLine();

            Console.WriteLine("INGRESE EL SUELDO: ");
            sueldo = Convert.ToDouble(Console.ReadLine());

            suel_Anu = sueldo * 12;

            ISR = 0;

            if (suel_Anu < 416220)
            {
                Console.WriteLine($"EL ISR A PAGAR ES N/A");
            }
            else if (suel_Anu >= 416220 && suel_Anu <= 624329)
            {
                ISR = (suel_Anu - 416220) * 0.15;
                Console.WriteLine("EL ISR A PAGAR ES " + ISR);
            }
            else if (suel_Anu >= 624330 && suel_Anu <= 867123) 
            {
                ISR = (suel_Anu - 624330) * 0.20 + 31216.5;
                Console.WriteLine("EL ISR A PAGAR " + ISR);
            }
            else if (suel_Anu >= 867124)
            {
                ISR = (suel_Anu - 867124) * 0.25 + 79776.5;
                Console.WriteLine("EL ISR A PAGAR " + ISR);
            }

            Console.WriteLine($"EL SUELDO DEL EMPLEADO {empl} ES: { sueldo}");
            Console.WriteLine($"EL SUELDO ANUAL DE DISTIGUIDO EMPLEADO {empl} ES: {suel_Anu}");

            double ISRMensual = ISR / 12;
            Console.WriteLine($"EL ISR DEL EMPLEADO empl {empl} ES: {ISRMensual}");
        }
    }
}
    
