using System;

namespace AfleveringFredag
{
    internal class Gui
    {

        public Gui(string mærke, string model, string årgang)
        {
            // 01/01/2002
            // 01.01.2002
            // 01-01-2002

            string[] årgangSplit = årgang.Split('/');
            int day = Convert.ToInt32(årgangSplit[0]);

            string[] monthSplit = årgang.Split('/');
            int month = Convert.ToInt32(årgangSplit[1]);

            string[] yearSplit = årgang.Split('/');
            int year = Convert.ToInt32(årgangSplit[2]);

            DateTime dtÅrgang = new DateTime(day, month, year);

            BilInfo bilInfo = new BilInfo();
            bilInfo.BilMærke = mærke;
            bilInfo.BilModel = model;
            bilInfo.BilÅrgang = årgang;
            bilInfo.BilSyn = synshal();

            var Today = DateTime.Today;

            if (bilInfo.BilSyn>Today.AddYears(-2))
            {
                Console.WriteLine("Din bil skal ikke til syn");

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