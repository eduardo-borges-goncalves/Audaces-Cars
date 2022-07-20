using ConsoleApp1.Models;
using ConsoleApp1.Services;

var optionSelected = "s";
do
{
    Menu.firstMenu();

    optionSelected = Console.ReadKey().KeyChar.ToString().ToUpper();

    switch (optionSelected)
    {
        case "1":
            RegisterVehicle.chooseVehicle();
            break;
        case "2":
            Console.WriteLine("opção 2");
            break;    
        case "3":
            Console.WriteLine("opção 3");
            break;    
        case "4":
            Console.WriteLine("opção 4");
            break;    
        case "S":
            Console.WriteLine("opção S");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
} while (optionSelected != "S");



// lista de carros
// lista de motos 
// lista de triciclos
// lista de camionetes
// lista de veículos 
// lista de vendas

// lista de carros vendidos

// Menu

// 2 - vender veículo 
// lista menu com o índice dos carros, 
// if ela digitar um valor entre 0 e cars.length. venda o veículo. 
// else opção inválida 
// var opcaoDigitada = parseInt(Console.ReadLine())
// digite o cpf do comprador:
// digite o valor da venda:
// date = Date.now()
// cars[opcaoDigitada].sellVehicle(cpf, date, valor )

// 3 - listar veículo 
// 4 - veículos disponíveis 
// 5 - veículos vendidos 

// Services
// Cadastrar carro -> cadastra o carro e adiciona na lista de carros 
// Criar moto 
// Criar triciclo
// Criar caminhonete 
// Vender carro -> vende e adiciona na lista de carros vendidos 

// Venda 
// Veículo 
// CPF comprador 
// Valor 
// Data


