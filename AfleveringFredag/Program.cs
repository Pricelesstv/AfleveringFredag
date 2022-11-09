using System;
using AfleveringFredag;

Console.WriteLine("Hvad er din bilmærke:");
string? mærke = Console.ReadLine();

Console.WriteLine("Hvad er din bilmodel:");
string? model = Console.ReadLine();

Console.WriteLine("Hvad er din årgang:");
string? årgang = Console.ReadLine();

new Gui(mærke, model, årgang);


