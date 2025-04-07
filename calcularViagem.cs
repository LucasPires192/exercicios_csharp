using System;

class Viagem{
    static void Main() {
        string entrada;
        double distancia;
        double consumo;
        double preco;
        
        while(true){
            Console.WriteLine("Calculadora de Custo de viagem");
            while(true){
                Console.WriteLine("Digite a distancia da viagem(Km): ");
                entrada = Console.ReadLine();
                if(double.TryParse(entrada, out var d)){
                    distancia = d;
                    Console.Clear();
                    break;
                }else{
                    Console.Clear();
                    Console.WriteLine("Valor inválido!");
                    continue;
                }
            }
            while(true){
                Console.WriteLine("Digite a consumo de combustivel do carro(km por litro): ");
                entrada = Console.ReadLine();
                if(double.TryParse(entrada, out var c)){
                    if(c != 0){
                        consumo = c;
                        Console.Clear();
                        break;
                    }else{
                        Console.Clear();
                        Console.WriteLine("O consumo deve ser maior que 0!");
                    }
                }else{
                    Console.Clear();
                    Console.WriteLine("Valor inválido!");
                    continue;
                }
            }
            while(true){
                Console.WriteLine("Digite a preço do combustivel por litro: ");
                entrada = Console.ReadLine();
                if(double.TryParse(entrada, out var p)){
                    preco = p;
                    Console.Clear();
                    break;
                }else{
                    Console.Clear();
                    Console.WriteLine("Valor inválido!");
                    continue;
                }
            }
            
            double resultado = (distancia / consumo) * preco;
            
            Console.Clear();
            Console.WriteLine($"Distancia: {distancia} Km");
            Console.WriteLine($"Consumo: {consumo} Km por litro");
            Console.WriteLine($"Preço: R$ {preco.ToString("F")}");
            Console.WriteLine($"Custo da viagem: R$ {resultado.ToString("F")}");
            
            Console.WriteLine("Deseja calcular o preço de outra viagem?\nSim ou Nao");
            string resposta = Console.ReadLine().ToLower();
            
            if(resposta == "sim"){
                Console.Clear();
                continue;
            }else{
                Console.WriteLine("Programa finalizado");
                break;
            }
        }
    }
}