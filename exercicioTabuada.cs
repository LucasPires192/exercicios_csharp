using System;

class Tabuada{
  static void Main() {
    while(true){
        Console.WriteLine("Digite o numero que voce deseja ver a tabuada: ");
        string entrada = Console.ReadLine();
        
        if(int.TryParse(entrada, out var numero)){
            Console.Clear();
            for(int i = 1; i <= 10; i++){
                Console.WriteLine($"{numero} x {i} = {i * numero}");
            }
        }else{
            Console.Clear();
            Console.WriteLine("Valor Inválido!");
            continue;
        }
        Console.WriteLine("Deseja ver tabuada de outro numero?\nSim ou Não");
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