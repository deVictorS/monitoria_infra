using System;

namespace variaveis
{
    public class principais_variaveis{
        public static void Executar()
        {
            principais_variaveis var = new principais_variaveis();

            //Variáveis (principais):

            string nome = "Victor";
            int idade = 22;             //armazena 32 bits
            long salario = 4000;        //armazena 64 bits
            float nota1 = 7.3f;         //ponto flutuante (frações ou números com vírgula)
            double nota2 = 7.3;         //float: 4 bytes; double: 8 bytes; decimal: 16 bytes
            decimal nota3 = 8.0m;       //muita precisão
            bool cnh = false;           //sim ou não
            char tipo = 'A';            //leta
            var                         //dinâmico, não precisa especificar o tipo de variável

            Console.WriteLine($"Nome: {nome}, {idade} anos");
        }
    }
}