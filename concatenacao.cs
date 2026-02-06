using System;

namespace concatencao;
{
    public static void Executar()
    {
        concatencao conc = new concatencao();

        //Concatenação:

        string marca1 = "Harley Davidson";
        int ano1 = 2026;
        int cc1 = 1800;

        string marca2 = "Royal Enfield"
        int ano2 = 2020;
        int cc2 = 350;


        Console.WriteLine("A marca da moto é " + marca1 + "," + "fabricada em" + ano1);     //forma que dificulta legibilidade
        Console.WriteLine($"A marca da moto é {marca2}, fabricada em {ano2}")               //boas práticas
    }
}