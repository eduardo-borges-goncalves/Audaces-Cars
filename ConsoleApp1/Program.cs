using ConsoleApp1.Models;


var date = new DateOnly(2022, 01, 05);

var firstVehicle = new Vehicle(date, "Honda", "NKC2864", 134000, "01101101101101", "White");

firstVehicle.BuyVehicle(7);
firstVehicle.ListData();


// lista de carros
// lista de motos 
// lista de triciclos
// lista de camionetes
// lista de veículos 
// lista de vendas

// lista de carros vendidos

// Menu
// 1 - cadastrar veículo 
    // 1 Carro
    // 2 Moto ou Triciclo
    // 3 Caminhonete 
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


