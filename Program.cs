using System;

namespace fechas
{
    class Program
    {
        static void Main(string[] args)
        {
            var fecha =  DateTime.Now;

            Console.WriteLine($"La fecha es: {fecha}");

            Console.WriteLine($"El valor de la fecha es: {fecha}");
            var fecha2 = new DateTime(2015, 12, 31);
            Console.WriteLine($"El valor de la fecha es: {fecha2}");
            var fechaconhora = new DateTime(2015, 12, 31, 8, 30, 30);
            Console.WriteLine($"El valor de la fechaconhora es: {fechaconhora}");
            Console.WriteLine($"El valor de la fechaconhora es: {fechaconhora.ToString()}");


            Console.WriteLine($"El valor de la fechaconhora es: {fechaconhora.ToString("MM/dd/yyyy")}");
            Console.WriteLine($"El valor de la fechaconhora es: {fechaconhora.ToString("dd-MM-yyyy")}");
            Console.WriteLine($"El valor de la fechaconhora es: {fechaconhora.ToString("dd**MM**yyyy hh:mm:ss")}");
            Console.WriteLine($"Adicionando 10 dias a la fecha 2: {fecha2.AddDays(10).ToString()}");
            Console.WriteLine($"Adicionando 10 dias a la fecha 2 su dia es: {fecha2.DayOfWeek.ToString()}");




        }
    }
}
