// 1) O que é o C#?
// R: 

// Linguagem de programação usada para desenvolvimento de aplicativos, jogos (Unity),
// desenvolvimento web e desenvolvimento desktop.

// Funciona dentro do .NET Framework ou .NET Core:
// .NET Framework é a versão tradicional, focada em Windows, enquanto o .NET Core, hoje chamada
// de .NET é multiplataforma e mais moderno. Algumas bibliotecas funcionam em ambos, mas a compatibilidade
// depende da tecnologia usada. O .NET Standard ajuda na interoperabilidade.

// 2) Como começar com C#?
// R: 
// Instalar o .NET SDK e ter uma IDE de desenvolvimento.

using exibir;
using variaveis;

namespace principal
{
    class Programação
    {
        static async Task Main(string[] args)
        {
            Console.Clear()
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║ INTRODUÇÃO AO C# - MONITORIA 2026  ║");
            Console.WriteLine("╚════════════════════════════════════╝")

            string opcao;
            
            do
            {
                Console.WriteLine("\n            MENU PRINCIPAL       ");
                Console.WriteLine("     ╔══════════════════════════╗");
                Console.WriteLine("     ║1 - EXIBIÇÃO DE DADOS     ║");
                Console.WriteLine("     ║2 - VARIÁVEIS             ║");
                Console.WriteLine("     ║3 - RECOMENDAR PACOTE (IA)║");
                Console.WriteLine("     ║4 - LISTAR CLIENTES       ║");
                Console.WriteLine("     ║5 - LISTAR PACOTES        ║");
                Console.WriteLine("     ║6 - BUSCAR POR CLIENTE    ║");
                Console.WriteLine("7 - BUSCAR PACOTE PELA ORIGEM");
                Console.WriteLine("     ║7 - BUSCAR POR PACOTE     ║");
                Console.WriteLine("     ║8 - EDITAR CLIENTE        ║");
                Console.WriteLine("     ║0 - SAIR                  ║");
                Console.WriteLine("     ╚══════════════════════════╝");

                Console.WriteLine("Escolha uma opção: ")
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                    exibindo_dados.Executar();
                    break;

                    case "2":
                    principais_variaveis.Executar();
                    break;

                    case "3":
                    principais_variaveis.Executar();
                    break;

                }
            }
        }
    }
}



//Operadores:

//aqui temos um exemplo de subtração, mas o operador (-) poderia facilmente ser substituído por:
//(+) soma
//(*) multiplicação
//(/) divisão
//(%) módulo (resto de divisão)

Console.WriteLine(ano1 - ano2);

int diferenca;
diferena = ano1 - ano2;       
Console.WriteLine($"A diferença de anos entre as motos é: {diferenca}");

//Operadores de comparação:

//aqui temos um exemplo de igualdade, mas o operador (==) poderia facilmente ser substituído por:

//(!=) diferente
//(<) menor 
//(>) maior
//(>=) maior igual
//(<=) menor igual

if (cc1 == cc2){
    Console.WriteLine("É igual")
}

//(&&) and (se um E o outro for verdadeiro, saída é verdadeira)
//(||) or (se um OU outro for verdadeiro, saída é verdadeira)

bool boleano1 = true;
bool boleano2 = true;
bool boleano3 = false;
bool boleano4 = false;

if (boleano1 && boleano2){
    Console.WriteLine("Ambos são verdadeiros");
}

if (boleano1 && boleano3){
    Console.WriteLine("Um desses é falso");
}

if (boleano2 || boleano4){
    Console.WriteLine("Pelo menos um desses é verdadeiro");
}

//(!) negação
//Negando uma variável: (!boleano1) se torna false mesmo sendo true na declaração


//Funções ou métodos (mesma coisa):

//estrutura: tipo de função nome (parâmetro ou parâmetros)

static void Veiculo(string carro, float motor){
    Console.WriteLine(carro, motor);
}

Veiculo("Virtus", 2.0);

//void diz para uma função que ela não retorna valor
//neste caso ele somente exibe, logo não teria necessidade de tipar ela (colocar string na frente de void)
//se quisesse retornar: colocar return "variavel_a_retornar"


//Estrutura de controle:

//if else: se a condição for verdadeira, executa a primeira estrutura, se não, executa a próxima

if (idade >= 18){
    Console.WriteLine("Apto a dirigir pela idade.");
}

else{
    Console.WriteLine("Não apto a dirigir, menor de idade.")
}

//switch case: será verdadeiro caso a variável declarada seja igual a inserida

string cor = "azul"

switch (cor){
    case "azul":
        Console.WriteLine("A cor é azul");
        break;

    case "vermelho":
        Console.WriteLine("A cor é vermelha");
        break;

    default:
        Console.WriteLine("Outra cor");
        break;

}


//Laços de repetição:

//for: para determinada condição, continua executando o código até a condição ser estabelecida

for (int i = 0; i < 5; i++){
    Console.WriteLine($"Número: {i}")
}

//while: enquanto a condição não for estabelecida, continue executando o código

int j = 0;

while (j < 5){
    Console.WriteLine($"Número: {j}")
    j++;        //deve haver o incrementar ou decremntar (j--) para não entrar em loop infinito
}

//do while:

do{
    Console.WriteLine("Executando pelo menos uma vez");
    j++;
} while(j < 5);

//Array/foreach:

//array:

string[] frutas = {"Maça", "Banana", "Pera"};       // 0, 1, 2

foreach (string fruta in frutas){
    
    Console.WriteLine($"A fruta é: {fruta}")        //para cada fruta dentro do array (vetor), printe as sequencialmente
                                                    //conforme o índice
}

Console.WriteLine($"Primeira fruta: {frutas[0]}")


//Programação Orientada à Objetos: paradigma baseado em classes e objetos que facilita a manutenção e reutilização do código
//Tipo: int, float, string...
//Classes: quando cria-se uma classe (ex: class Pessoa) cria-se um novo tipo
//Classes e tipos servem para agrupar características e comportamentos que têm propósitos específicos
//Ex: classe Pessoa agrupa comportamentos e características específicas de pessoas.
//Objeto != Classe
//Classe: pedaço de código com características e funcionalidades
//Objeto: instância de um tipo ou de uma classe
//Se temos:

// Pessoa pessoa1 = new Pessoa();
//pessoa1.genero = "M";
//pessoa1.nacionalidade = "Brasileiro";  \\ aqui estamos setando as características do objeto

//Operador new inicializa, executa o construtor da classe e retorna uma instância dela que estará na memória,
//logo, a variável pessoa1 que é do tipo Pessoa, tem a referência por objeto neste exemplo, que por sua vez, vai ter
//acesso às características e funcionalidades (pode existir mais de uma)
//objeto so se cria de fato quando o programa está sendo executado (em tempo de execução)
//após finalização



