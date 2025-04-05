using System;

class Carros
{
    static void Main(){
        //Criando a lista de categorias
        string[] categorias = {"Hatch", "Sedan", "SUV"};

        //Criando a lista da categoria Hatch
        string[,] hatch = 
        {
        {"Fit","50.000", "1.5", "Flex"}, 
        {"Corsa", "35.000", "1.6", "Flex"},
        {"Palio", "25.000", "1.0", "Gasolina"}
        };

        //Criando a lista da categoria Sedan
        string[,] sedan = 
        {
        {"Civic", "80.000", "1.5", "Flex"}, 
        {"Corolla", "90.000", "1.5", "Flex"}, 
        {"Siena", "50.000", "1.8", "Flex"}
        };

        //Criando a lista da categoria SUV
        string[,] suv = 
        {
        {"Creta", "110.000", "2.0", "Flex"},
        {"ix35", "68.000", "2.0", "Flex"},
        {"SantaFé", "85.000", "2.5", "Gasolina"}
        };

        string[,] categoria;

        Console.Clear();

        //Inicio do loop
        while(true){
            Console.WriteLine("Escolha um categoria de carro: ");
            //Mostra as opçoes de categoria
            for(int i = 0; i < categorias.Length; i++){
                Console.WriteLine($"{i + 1}. {categorias[i]}");
            }

            string opcaoCat = Console.ReadLine();
            string msgCategoria = "";

            switch(opcaoCat){
                case "1":
                    categoria = hatch;
                    Console.Clear();
                    msgCategoria = "Hatch: ";
                    break;
                case "2":
                    categoria = sedan;
                    Console.Clear();
                    msgCategoria ="Sedan: ";
                    break;
                case "3":
                    categoria = suv;
                    Console.Clear();
                    msgCategoria = "SUV: ";
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção de categoria invalido! Digite novamente");
                    continue;
            }
            while(true){
                Console.WriteLine(msgCategoria);
                for(int i = 0; i < categoria.GetLength(0); i++){
                    Console.WriteLine($"{i + 1}. {categoria[i, 0]}");
                }

                string entrada = Console.ReadLine();
                int opcaoMod;

                Console.Clear();
                if(int.TryParse(entrada, out opcaoMod) && opcaoMod >= 0 && opcaoMod <= categoria.GetLength(0)){
                    Console.WriteLine($"Modelo: {categoria[opcaoMod - 1, 0]}\nKilometragem: {categoria[opcaoMod - 1, 1]}\nMotor: {categoria[opcaoMod - 1, 2]}\nCombustivel: {categoria[opcaoMod - 1, 3]}");
                    break;
                }else{
                    Console.Clear();
                    Console.WriteLine("Opção de modelo invalido! Digite novamente");
                    continue;
                }
            }

            Console.WriteLine("Deseja pesquisar outro carro?\nSim ou Não");
            string resposta = Console.ReadLine().ToLower();

            if(resposta == "sim"){
                Console.Clear();
                continue;
            }else{
                Console.Clear();
                Console.WriteLine("Programa finalizado!");
                break;
            }
        }
    }
}