// See https://aka.ms/new-console-template for more information


Console.WriteLine("Bitte geben Sie ihre erste Zahl ein: \n");
double Zahl1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Bitte geben Sie ihre mathematischen Operator ein: \n");
char operation = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Bitte geben Sie ihre zweite Zahl ein: \n");
double Zahl2 = Convert.ToDouble(Console.ReadLine());

switch(operation)
{
    case '+':
        Console.WriteLine("{0} {1} {2} = {3}",Zahl1, operation, Zahl2, Zahl1 + Zahl2);
        break;

    case '-':
        Console.WriteLine("{0} {1} {2} = {3}",Zahl1, operation, Zahl2, Zahl1 - Zahl2);
        break;

    case '/':
        Console.WriteLine("{0} {1} {2} = {3}",Zahl1, operation, Zahl2, Zahl1 / Zahl2);
        break;

    case '*':
        Console.WriteLine("{0} {1} {2} = {3}", Zahl1, operation, Zahl2, Zahl1 * Zahl2);
        break;

        default:
        Console.WriteLine("Ungültiger Werte, bitte starten Sie das Programm neu.");
        break;
}

Console.ReadKey();


