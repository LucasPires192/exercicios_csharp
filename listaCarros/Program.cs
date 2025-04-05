using System;   //Importa a funções e metodos básicos da linguagem c#

class Carros    //Criação da classe Carro
{
    static void Main() //Criação da função principal do programa
    {
        string[] categorias = {"Hatch", "Sedan", "SUV"};    //Criação da lista de categorias

        //Criação da lista da categoria Hatch
        string[,] hatch = 
        {
        {"Fit","50.000", "1.5", "Flex"}, 
        {"Corsa", "35.000", "1.6", "Flex"},
        {"Palio", "25.000", "1.0", "Gasolina"}
        };  

        //Criação da lista da categoria Sedan
        string[,] sedan = 
        {
        {"Civic", "80.000", "1.5", "Flex"}, 
        {"Corolla", "90.000", "1.5", "Flex"}, 
        {"Siena", "50.000", "1.8", "Flex"}
        };

        //Criação da lista da categoria SUV
        string[,] suv = 
        {
        {"Creta", "110.000", "2.0", "Flex"},
        {"ix35", "68.000", "2.0", "Flex"},
        {"SantaFé", "85.000", "2.5", "Gasolina"}
        };

        string[,] categoria; //Criação de uma variavel para armazenar a categoria escolhida

        Console.Clear();    //Limpa o console

        //Inicio do loop principal
        while(true){
            Console.WriteLine("Escolha um categoria de carro: ");

            //Mostra as opçoes de categoria
            for(int i = 0; i < categorias.Length; i++){ //Laço for que roda de acordo com a quantidade de indices da lista categoria
                Console.WriteLine($"{i + 1}. {categorias[i]}"); //Mostra cada valor armazenado na lista categorias
            }

            string opcaoCat = Console.ReadLine();   //Variavel para armazenar a resposat do usuario
            string msgCategoria;    //Variavel para armazenar a mensagem que aparece com a categoria que foi escolhida

            switch(opcaoCat){   //Switch para verificar a escolha de categoria do usuario
                case "1":   
                    categoria = hatch;  //Caso digite 1 a variavel categoria vai armazenar a lista hatch
                    Console.Clear();    //Limpa o console
                    msgCategoria = "Hatch: ";   //Define a mensagem que vai aparecer nas opções de modelos
                    break;  //Finaliza o switch
                case "2":   
                    categoria = sedan;  //Caso digite 2 a variavel categoria vai armazenar a lista sedan
                    Console.Clear();    //Limpa o console
                    msgCategoria ="Sedan: ";    //Define a mensagem que vai aparecer nas opções de modelos
                    break;  //Finaliza o switch
                case "3":   
                    categoria = suv;    //Caso digite 3 a variavel categoria vai armazenar a lista hatch
                    Console.Clear();    //Limpa o console
                    msgCategoria = "SUV: "; //Define a mensagem que vai aparecer nas opções de modelos
                    break;  //Finaliza o switch
                default:    //Caso digite um valor invalido
                    Console.Clear();    //Limpa o console
                    Console.WriteLine("Opção de categoria invalido! Digite novamente"); //Mostra a mensagem de erro
                    continue;   //Volta para o inicio do loop
            }
            //Inicio do loop da escolha de modelos
            while(true){
                Console.WriteLine(msgCategoria);    //Mostra a mensagem com a categoria que foi escolhida
                
                //Mostra as opções de modelos
                for(int i = 0; i < categoria.GetLength(0); i++){ //Laço for que roda de acordo com a quantidade de linha da lista bidimencional
                    Console.WriteLine($"{i + 1}. {categoria[i, 0]}");   //Mostra o primeiro valor da linha que no caso é os nomes dos modelos
                }

                string entrada = Console.ReadLine();    //Variavel para armazenar o que usuario digitou
                int opcaoMod;   //Criação de uma variavel vazia para armazenar a opcao que usuario digitou convertida para inteiro

                Console.Clear();    //Limpa o console
                
                //Inicio do ifelse para fazer 3 verificações
                //Tenta converter o que o usuario digitou para inteiro caso consiga, passe o valor para a variavel opcaoMod, senão retorna falso
                //Verifica se a variavel opcaoMod é maior ou igual 0 zero e menor ou igual a quantidade de linhas da lista categoria, para garantir que a opcao esta dentro do index da lista
                if(int.TryParse(entrada, out opcaoMod) && opcaoMod >= 0 && opcaoMod <= categoria.GetLength(0)){
                    Console.WriteLine($"Modelo: {categoria[opcaoMod - 1, 0]}"); //Mostra o nome do modelo esclhido
                    Console.WriteLine($"Preço: R$ {categoria[opcaoMod - 1, 1]}");   //Mostra a preço do modelo
                    Console.WriteLine($"Motor: {categoria[opcaoMod - 1, 2]}");  //Mostra o tipo de motor do modelo
                    Console.WriteLine($"Combustivel: {categoria[opcaoMod - 1, 3]}"); //Mostra o tipo de combustivel do modelo
                    break;  //Finaliza o loop de escolha de modelos
                }else{  //Caso o usuario digite um valor invalido na escolha de modelos
                    Console.Clear();    //Limpa o console
                    Console.WriteLine("Opção de modelo invalido! Digite novamente");    //Mostra a mensagem de erro
                    continue;   //Volta para o inicio do loop de escolha de modelos
                }
            }

            Console.WriteLine("Deseja pesquisar outro carro?\nSim ou Não"); //Mensagem para perguntar se o usuario deseja pesquisar outro carro ou finalizar o programa
            string resposta = Console.ReadLine().ToLower(); //Variavel para armazenar o que usuario digitou e transformar todas as letra em minusculas

            if(resposta == "sim"){  //Verifica se o usuario digitou sim
                Console.Clear();    //Limpa o console
                continue;   //Volta para o inicio do loop principal
            }else{  //Caso o usuario digite qualquer coisa que não seja sim
                Console.Clear();    //Limpa o console
                Console.WriteLine("Programa finalizado!");  //Mostra a mensagem de finalização
                break;  //Finaliza o loop principal
            }
        }
    }
}