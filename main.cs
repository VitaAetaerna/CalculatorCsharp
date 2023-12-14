using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System;
using System.Collections;
using System.Text.RegularExpressions;
string zahl0;
string zahl1;
string zeichen;
double summe;
string eingabe;
string speichereingabe;
string SaveFilePath = "C:\\Users\\Leon\\Desktop\\Code\\Code BFI\\C#\\Taschenrechner\\Taschenrechnerself\\Taschenrechnerself\\RechenSpeicher.txt";
string commands;



Console.WriteLine("Commands: help, ClearSave, exit, calc");
commands = Console.ReadLine();



try
{
    switch (commands)
    {
        case "help":
            Console.WriteLine("Nicht mit einer 0 rechnen!");
            Console.WriteLine("Operatoren: +  -  *  /  ^  %");
            Console.WriteLine();

            break;

        case "ClearSave":
            System.IO.File.WriteAllText(SaveFilePath, string.Empty);
            Console.WriteLine();
            break;

        case "exit":
            Environment.Exit(0);
            break;

        case "calc":
            break;



    }


}
catch (Exception e)
{
    Console.WriteLine(e);
}


do
{

    try
    {
        do
        {
            Console.WriteLine("Gib die erste Zahl ein");
            zahl0 = Console.ReadLine();

            Console.WriteLine("Gib die zweite Zahl ein");
            zahl1 = Console.ReadLine();

            if (Regex.IsMatch(zahl0, @"^[0-9]+$") && Regex.IsMatch(zahl1, @"^[0-9]+$"))
            {
                break;
            }
            else{ Console.WriteLine("Keinee Gültige Zahl!"); Console.WriteLine(""); zahl0 = ""; zahl1 = ""; }

        } while (zahl0 == "" || zahl1 == "");


        int num0 = Convert.ToInt32(zahl0);
        int num1 = Convert.ToInt32(zahl1);

        

        if (num0 == 0 || num1 == 0)
        {
            throw new DivideByZeroException("Keine 0 verwenden!!!");
        }

        try
        {
            Console.WriteLine("Gib einen Operator an!");
            zeichen = Console.ReadLine();

            switch (zeichen)
            {
                case "+":
                    summe = num0 + num1;
                    Console.WriteLine(summe);
                    Console.WriteLine("Willst du es speichern? y/n");
                    speichereingabe = Console.ReadLine();
                    if ("y" == speichereingabe)
                    {
                        using (StreamWriter writer = new StreamWriter(SaveFilePath))
                        {
                            writer.WriteLine("Gespeicherte Rechnung " + DateTime.Now);
                            Console.WriteLine(num0.ToString(), zeichen.ToString(), num1.ToString());
                            writer.WriteLine(summe);
                        }
                    }
                    else break;
                    break;
                case "-":
                    summe = num0 - num1;
                    Console.WriteLine(summe);
                    Console.WriteLine("Willst du es speichern? y/n");
                    speichereingabe = Console.ReadLine();
                    if ("y" == speichereingabe)
                    {
                        using (StreamWriter writer = new StreamWriter(SaveFilePath))
                        {
                            writer.WriteLine("Gespeicherte Rechnung " + DateTime.Now);
                            Console.WriteLine(num0.ToString(), zeichen.ToString(), num1.ToString());
                            writer.WriteLine(summe);
                        }
                    }
                    else break;
                    break;
                case "*":
                    summe = num0 * num1;
                    Console.WriteLine(summe);
                    Console.WriteLine("Willst du es speichern? y/n");
                    speichereingabe = Console.ReadLine();
                    if ("y" == speichereingabe)
                    {
                        using (StreamWriter writer = new StreamWriter(SaveFilePath))
                        {
                            writer.WriteLine("Gespeicherte Rechnung " + DateTime.Now);
                            Console.WriteLine(num0.ToString(), zeichen.ToString(), num1.ToString());
                            writer.WriteLine(summe);
                        }
                    }
                    else break;
                    break;
                case "/":
                    summe = num0 / num1;
                    Console.WriteLine(summe);
                    Console.WriteLine("Willst du es speichern? y/n");
                    speichereingabe = Console.ReadLine();
                    if ("y" == speichereingabe)
                    {
                        using (StreamWriter writer = new StreamWriter(SaveFilePath))
                        {
                            writer.WriteLine("Gespeicherte Rechnung " + DateTime.Now);
                            Console.WriteLine(num0.ToString(), zeichen.ToString(), num1.ToString());
                            writer.WriteLine(summe);
                        }
                    }
                    else break;
                    break;
                case "%":
                    summe = num0 % num1;
                    Console.WriteLine(summe);
                    Console.WriteLine("Willst du es speichern? y/n");
                    speichereingabe = Console.ReadLine();
                    if ("y" == speichereingabe)
                    {
                        using (StreamWriter writer = new StreamWriter(SaveFilePath))
                        {
                            writer.WriteLine("Gespeicherte Rechnung " + DateTime.Now);
                            Console.WriteLine(num0.ToString(), zeichen.ToString(), num1.ToString());
                            writer.WriteLine(summe);
                        }
                    }
                    else break;
                    break;
                case "^":
                    summe = num0 ^ num1;
                    Console.WriteLine(summe);
                    Console.WriteLine("Willst du es speichern? y/n");
                    speichereingabe = Console.ReadLine();
                    if ("y" == speichereingabe)
                    {
                        using (StreamWriter writer = new StreamWriter(SaveFilePath))
                        {
                            writer.WriteLine("Gespeicherte Rechnung " + DateTime.Now);
                            Console.WriteLine(num0.ToString(), zeichen.ToString(), num1.ToString());
                            writer.WriteLine(summe);
                        }
                    }
                    else break;
                    break;
                default:
                    Console.Write("Du hast keinen Operator angegeben");
                    Console.WriteLine();
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    catch (FormatException f)
    {
        Console.WriteLine(f); throw;
    }
    Console.WriteLine("Nochmal rechnen? y/n");
    eingabe = Console.ReadLine();

    if ("y" == eingabe.ToLower())
    {
        Console.Clear();
    }
    else if ("n" == eingabe.ToLower())
    {
        Environment.Exit(0);
    }

} while ("y" == eingabe.ToLower());     

