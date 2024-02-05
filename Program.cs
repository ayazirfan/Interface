
using Interface;
using Interfacee;


Focus focus = new();
System.Console.WriteLine(focus.HangiMarkanınAraci());
System.Console.WriteLine(focus.KactekerlektenOlusur());
System.Console.WriteLine(focus.StandartRengiNe());

System.Console.WriteLine("************");

Civic civic = new Civic();
System.Console.WriteLine(civic.HangiMarkanınAraci());
System.Console.WriteLine(civic.KactekerlektenOlusur());
System.Console.WriteLine(civic.StandartRengiNe());

Deneme deneme = new Deneme();
deneme.denemeSinifi();