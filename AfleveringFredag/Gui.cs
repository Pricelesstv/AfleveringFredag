using System;

namespace AfleveringFredag
{
    internal class Gui
    {
        int år = 730;
        public Gui()
        {
            BilInfo bilInfo = new BilInfo();
            bilInfo.BilMærke = GetString("Bilens Mærke: ");
            bilInfo.BilModel = GetString("Bilens Model: ");
            bilInfo.BilÅrgang = GetString("Bilens Årgang: ");
            bilInfo.BilSyn = synshal();

            var Today = DateTime.Today;

            if (bilInfo.BilSyn>Today.AddYears(-2))
            {
                Console.WriteLine("´Din bil skal ikke til syn");

            }
            else 
            {

                Console.WriteLine("Din Bil skal til syn");
            }



        }
        private string GetString(string type)
        {
            string input;
            do
            {
                Console.Clear();
                Console.WriteLine(type);
                input = Console.ReadLine();
            }
            while (input == null && input != "");
            return input;
        }
        private DateTime synshal()
        {
            DateTime dateOnly;
            do
            {
                Console.Clear();
                Console.WriteLine("Bilens sidst synet dato: ");
            } while (!DateTime.TryParse(Console.ReadLine(), out dateOnly));
            return dateOnly;
        }
    }
}