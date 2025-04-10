using System;

class Program{
    static void Main() {
        
        int numero1 = PedirNumero("Digite o 1° número: ");
        int numero2 = PedirNumero("Digite o 2° número: ");
        int numero3 = PedirNumero("Digite o 3° número: ");
        
        Console.WriteLine($"{numero1} + {numero2} + {numero3} = {Somar(numero1, numero2, numero3)}");
        
        Console.WriteLine("Digite seu nome!");
        string nome = Console.ReadLine();
        
        Console.WriteLine(Saudacao(nome));
        
        int numero = PedirNumero();
        
        Console.WriteLine(EhMultiploDeCinco(numero));
    }

    static int PedirNumero(string mensagem = "Digite um número: "){
        int num;
        while(true){
            Console.WriteLine(mensagem);
            string entrada = Console.ReadLine();
            if(!int.TryParse(entrada, out var n)){
                Console.WriteLine("Valor Invalido! Digite Novamente\n");        
            }else{
                num = n;
                break;
            }
        }
        return num;
    }
    
    static int Somar(int n1, int n2, int n3){
        return n1 + n2 + n3;
    }
    
    static string Saudacao(string nome){
        return $"Olá {nome}! Seja bem vindo!";
    }
    
    static string EhMultiploDeCinco(int num){
        int resultado = num % 5;
        if(resultado == 0){
            return $"O número {num} é multiplo de 5";
        }else{
            return $"O número {num} não é multiplo de 5";
        }
    }
}