using System;

class Program{
    static void Main() {
        
        int numero1 = PedirNumero("Digite o 1° número: "); //Chama a função PedirNumero() e armazena o resultado na variavel numero1
        int numero2 = PedirNumero("Digite o 2° número: ");  //Chama a função PedirNumero() e armazena o resultado na variavel numero2
        int numero3 = PedirNumero("Digite o 3° número: ");  //Chama a função PedirNumero() e armazena o resultado na variavel numero3
        
        Console.WriteLine($"{numero1} + {numero2} + {numero3} = {Somar(numero1, numero2, numero3)}");   //Mostra um texto formatado com os numeros e o resultado da função Somar() que foi chamada
        
        Console.WriteLine("Digite seu nome!");  //Mostra uma mensagem
        string nome = Console.ReadLine();   //Pega o que o ususario deigitar e armazena na variavel nome
        
        Console.WriteLine(Saudacao(nome));  //Chama a função Saudacao() como o nome passado como parametro
        
        int numero = PedirNumero(); //Chama a função PedirNumero() e armazena o resultado na variavel numero
        
        Console.WriteLine(EhMultiploDeCinco(numero));   //Mostra uma mensagem com resultado da função EhMultiploDeCinco() que foi chamado
    }

    //Inicio da função para pedir um numero
    static int PedirNumero(string mensagem = "Digite um número: "){ //Define o tipo de retorno como tipo inteiro, o nome e um parametro chamado mensagem e dando um valor padrão
        int num;    //Cria uma varivael local para armazenar o numero
        while(true){    //Inicia um loop de verificao de valor valido
            Console.WriteLine(mensagem);    //Mostra a mensagem 
            string entrada = Console.ReadLine();    //Pega o que o ususario digitou e armazena na variavel local entrada
            if(!int.TryParse(entrada, out var n)){  //Tenta converter a variavel entrada do tipo string para tipo inteiro, caso não consigo retorna false, mas como tem um operador de negação, o if sera execultado, caso consiga converter cria uma varivael chamada n e armazena o valor converti nela e pula para o bloco do else
                Console.WriteLine("Valor Invalido! Digite Novamente\n");        //Mostra a mensagem de erro e reinicia o loop
            }else{
                num = n;    //Pega a variavel num e armazena o valor da variavel n que foi criada com a função TryParse
                break;  //Finaliza o loop
            }
        }
        return num; //Retorna o valor da variavel num
    }
    
    //Inicio da função de somar tres números
    static int Somar(int n1, int n2, int n3){   //Define o valor que vai ser retornado como tipo inteiro e tres numeros como parametro
        return n1 + n2 + n3;    //Retorna o valor da soma dos tres numeros
    }
    
    //Inicio da função de saudação 
    static string Saudacao(string nome){    //Define o valor que vai ser retornado com tipo string, e um parametro chamado nome
        return $"Olá {nome}! Seja bem vindo!";  //Retorna uma string formatada com o nome que foi passado como parametro
    }
    
    //Inicio da função EhMultiploDeCinco
    static string EhMultiploDeCinco(int num){   //Define o valor que vai ser retornado com tipo string e um parametro chamado num
        int resultado = num % 5;    //Cria uma variavel local chamado resultado e armazena o valor do resto da divisão do numero fornecido por cinco
        if(resultado == 0){ //Verifica se o resto da divisão por cinco seja zero
            return $"O número {num} é multiplo de 5";   //Caso seja zero, retorna um texto fomatado dizendo que o número é divisel por cinco
        }else{
            return $"O número {num} não é multiplo de 5";   //Caso seja diferente de zero, retorna um texto fomatado dizendo que o número não é divisel por cinco
        }
    }
}