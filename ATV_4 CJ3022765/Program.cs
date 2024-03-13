// See https://aka.ms/new-console-template for more information

//1

//int numero;

//Console.WriteLine("Me diga um numero:");
//numero = int.Parse(Console.ReadLine());

//if (numero % 2 == 0 )
//{
//    Console.WriteLine("É par");
//}
//else
//{
//    Console.WriteLine("É impar");
//}

//2

//float lado1, lado2, lado3;
// Console.WriteLine("lado 1");
//lado1 = float.Parse(Console.ReadLine());
//Console.WriteLine("lado 2");
//lado2 = float.Parse(Console.ReadLine());
//Console.WriteLine("lado 3");
//lado3 = float.Parse(Console.ReadLine());

//if (lado1 == lado2 && lado2 == lado3)
//{
//    Console.WriteLine("Equilatero!");
//}
//else
//{
//    if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
//    {
//        Console.WriteLine("Escaleno!");
//    }
//    else 
//    {
//    Console.WriteLine("Isóceles!");
//    }
//}

//3

//int numero, tentativa;


//Random gerador = new Random();
//numero = gerador.Next(1,100);

//Console.WriteLine("digite um numero entre 1 a 100:");
//tentativa = int.Parse(Console.ReadLine());

//if (numero == tentativa)
//{
//    Console.WriteLine("Acertou de primeira");
//}
//else
//{
//    if (numero < tentativa)//dica
//    {
//        Console.WriteLine("numero e menor que{0}", tentativa);
//    }
//    Console.WriteLine("digite um numero entre 1 a 100:");
//    tentativa = int.Parse(Console.ReadLine());

//    if (numero == tentativa)
//    {
//        Console.WriteLine("Acertou na segunda");
//    }
//}
//else
//{
//    Console.WriteLine("voce não tem mais tentativas");
//}


//4

//string nome, senha;

//Console.WriteLine("entre com o nome de usuario:");
//nome = Console.ReadLine();

//Console.WriteLine("entre com o nome de senha:");
//senha = Console.ReadLine();


//if (nome == "admin" && senha  == "admin123")
//{
//    Console.WriteLine("acesso concedido");
//}
//else
//{
//    Console.WriteLine("acesso negado");
//}

//5

//float nota;

//Console.WriteLine("entre com sua nota(0, 100)");
//nota = float.Parse(Console.ReadLine());

//if (nota > 100 || nota < 0)
//{
//    Console.WriteLine("nota valida");
//}
//else
//{
//    if (nota >= 90)
//    {
//        Console.WriteLine("conceituado A");
//            }
//    else
//    {
//        if (nota >=80)
//        {
//            Console.WriteLine("conceituado B");
//        }
//        else
//        {
//            if (nota >= 70)
//            {
//                Console.WriteLine("conceituado C");
//            }
//            else
//            {
//                if(nota >= 60)
//                {
//                    Console.WriteLine("conceituado D");
//                }
//                else
//                {
//                    if( nota >= 60)
//                    {
//                        Console.WriteLine("conceituado em D");
//                    }
//                }
//            }
//        }
//    }
//}


//6

//int jogador, pc;

//Console.WriteLine("Escolha:1- pedra, 2- papel, 3- tesoura");
//jogador = int.Parse(Console.ReadLine());

//Random gerador = new Random();
//pc = gerador.Next(1, 3);

//if (pc == jogador)
//    Console.WriteLine("deu empate");
//else
//{
//    if(pc == 1 && jogador == 2)
//        Console.WriteLine("jogador ganhou");
//}
//else
//{
//    if (pc == 1 && jogador == 3)
//        Console.WriteLine("computador ganhou");
//}
//else
//{
//    if (pc == 2 && jogador == 3)
//        Console.WriteLine("jogador");
//}
//else
//{
//    if (pc == 2 && jogador == 2)
//        Console.WriteLine("empate");
//}
//else
//{
//    if (pc == 2 && jogador == 1)
//        Console.WriteLine("pc");
//}
//else
//{
//    if (pc == 3 && jogador == 3)
//        Console.WriteLine("empate");
//}
//else
//{
//    if (pc == 3 && jogador == 2)
//        Console.WriteLine("pc");
//}
//else
//{
//    if (pc == 3 && jogador == 1)
//        Console.WriteLine("pc");
//}

//7



//8

//float peso, altura, imc;

//Console.WriteLine("me diga seu peso em kilos");
//peso = float.Parse(Console.ReadLine());

//Console.WriteLine("me diga sua altura em metros");
//altura = float.Parse(Console.ReadLine());

//imc = peso/altura;

//if (imc < 18.5f)
//{
//    Console.WriteLine("abaixo do peso");
//}
//else
//{
//    if (imc <= 24.9f)
//        Console.WriteLine("peso normal");

//else
//{
//        if (imc <= 29.9f)
//            Console.WriteLine("acima do peso");

//        else
//        {
//            if (imc <= 34.9f)
//                Console.WriteLine("obsidade grade 1");

//            else
//            {
//                if (imc <= 39.9f)
//                    Console.WriteLine("obsidade grade 2");

//                else
//                {
//                    Console.WriteLine("obsidade grade 3");
//                }
//            }
//        }
//    }
//}
