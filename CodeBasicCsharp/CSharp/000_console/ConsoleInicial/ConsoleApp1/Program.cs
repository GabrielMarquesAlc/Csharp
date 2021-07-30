using System;

namespace Programa_Console
{
   
    class Program
    {
        static void Main(String[] args)
        {
            string mensagem001 = "Como vai Mundo? /n Está tudo ok?";
            string mensagem002 = "Meu nascimento foi no ano abaixo";
            int numero = 1994;
            Console.WriteLine(mensagem001);
            Console.WriteLine(mensagem002);
            Console.WriteLine(numero);

            string name = "Bob";
            int messages = 3;
            decimal temperature = 34.4m;

            Console.Write("Hello, ");
            Console.Write(name);
            Console.Write("! You have ");
            Console.Write(messages);
            Console.Write(" in your inbox. The temperature is ");
            Console.Write(temperature);
            Console.Write(" celsius.");

            Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.WriteLine("\nOutput Directory:\t");
            Console.WriteLine(@"D:\invoices");

            ///Literal de cadeia de caracteres textual
            ///Um literal de cadeia de caracteres textual manterá todo o espaço em branco e os caracteres sem a 
            ///necessidade de escapar da barra invertida. 
            ///Para criar uma cadeia de caracteres textual, use a diretiva @ antes da cadeia de caracteres literal.

            ///Console.WriteLine(@"   c:\source\repos   
            ///            (this is where your code goes)"
            ///   );
            ///   


            ///Você também pode adicionar caracteres codificados em cadeias de caracteres literais usando a
            ///sequência de escape \u e, em seguida, um código de quatro caracteres representando algum caractere 
            ///em Unicode(UTF-16).

            // Kon'nichiwa World
            //Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

            ///INTERpolação
            ///Etapa 3: Use a interpolação de cadeia de caracteres com diversas cadeias de caracteres literais e variáveis.
            //Você pode executar várias operações de interpolação na mesma linha de código.
            ///Modifique o código escrito na Etapa 2 para o seguinte código:
            ///$
            ///

            string interpolacao_firstname = "Jhow";
            string interpolacao_greeting = "Hello my son,";

            Console.WriteLine($"{interpolacao_greeting}{interpolacao_firstname}!");

            //// desafio
            ///Esse código é meramente "uma solução possível". 
            ///Você pode ter alguma variação nas variáveis de nomenclatura ou nas sequências de escape de caractere usadas. 
            ///Você pode ter usado Console.Write() em vez de Console.WriteLine(). 
            ///Você pode ter tentado combinar tudo isso sem usar diversas variáveis.
            ///No entanto, desde que seu código siga as instruções do desafio e produza a saída desejada, parabéns!
            ///Prossiga para a verificação de conhecimentos na próxima unidade.
            

            string projectName = "ACME";
            string englishLocation = $@"c:\Exercise\{ projectName}\data.txt";
            Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
            Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");


            int primeiroNumero = 12;
            int segundoNumero = 7;

            Console.WriteLine(primeiroNumero + segundoNumero + " Anos de idade!");


            string numerosfirstName = "Jhonatan Arthur";
            
            Console.WriteLine(numerosfirstName + " vendeu " + segundoNumero + " acessórios.\n\n\n\n\n");
                                          
            ///////////////////////////////////////////////////////////////////////////////////////////
            /// Operações basicas
            int soma = 7 + 5;
            int subtracao = 7 - 5;
            int multiplicacao = 7 * 5;
            int divisao = 7 / 5;
            decimal divisaocomDecimal = 7.0m / 5;
            

            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Subtração: " + subtracao);
            Console.WriteLine("Produto: " + multiplicacao);
            Console.WriteLine("Divisão: " + divisao);
            Console.WriteLine("Divisão com Decimal" + divisaocomDecimal);


            ///Conversao de Inteiro em Decimal
            /// Neste caso, adicionaríamos (decimal) antes das variáveis first e second.

            int first = 7;
            int second = 5;
            decimal quotient = (decimal)first / (decimal)second;
            Console.WriteLine(quotient);

            ///Resto da divusão
            ///
            Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5));
            Console.WriteLine("Modulus of 7 / 5: " + (7 % 5));

            /// incrementar valores e subtrair valores 
            /// 
           int value = 1;

            value = value + 1;
            Console.WriteLine("First increment: " + value);

            value += 1;
            Console.WriteLine("Second increment: " + value);

            value++;
            Console.WriteLine("Third increment: " + value);

            value = value - 1;
            Console.WriteLine("First decrement: " + value);

            value -= 1;
            Console.WriteLine("Second decrement: " + value);

            value--;
            Console.WriteLine("Third decrement: " + value);
            int value2 = 1;
            value2++;
            Console.WriteLine("First: " + value2);
            Console.WriteLine("Second: " + value2++);
            Console.WriteLine("Third: " + value2);
            Console.WriteLine("Fourth: " + (++value2));


            // desafio
            // 

            int fahrenheit = 94;
            decimal celsius = (fahrenheit - 32m) * (5m / 9m);
            Console.WriteLine("The temperature is " + celsius + " Celsius.");



            /// Numeros Aleatorios 
 /*
 Criar uma instância de uma classe
Uma instância de uma classe é chamada de um objeto. Para criar uma instância de uma classe, use o operador new. 
Considere a seguinte linha de código que cria uma instância da classe Random para criar um 
objeto chamado dice:

    O operador new faz várias coisas importantes:

        Primeiro, ele solicita um endereço na memória do computador grande o suficiente para armazenar um novo objeto com
            base na classe Random.
            Ele cria o objeto e o armazena no endereço de memória.
            Ele retorna o endereço de memória para que ele possa ser salvo na variável dice.
*/

            Random dice = new Random();
            int roll = dice.Next(1, 7);
            Console.WriteLine(roll);
            /*
             Biblioteca de Classes do .NET e armazena a referência ao novo objeto em uma variável denominada dice.

            A segunda linha de código chama o método Next() do objeto dice que passa dois parâmetros: o 
                    valor mínimo e o máximo do número aleatório. O método Next() retorna o valor, que salvamos em uma variável chamada roll.

            A terceira linha de código chama o método WriteLine() para imprimir o valor de roll no console.
        
            Neste exemplo de código, estamos chamando um método da classe Random e da classe Console.
                No entanto, a maneira como estamos chamando esses métodos é diferente. O motivo pelo qual eles foram chamados
                       usando uma técnica diferente é porque alguns métodos são com estado e outros, sem estado.
             */

            ///metodosobrecarregado
            Random dice2 = new Random();
            int roll1 = dice2.Next();
            int roll2 = dice2.Next(101);
            int roll3 = dice2.Next(50, 101);

            Console.WriteLine($"First roll: {roll1}");
            Console.WriteLine($"First roll: {roll2}");
            Console.WriteLine($"First roll: {roll3}");


            /*
            O método Math.Max() é compatível com 11 versões sobrecarregadas para aceitar diferentes tipos de dados. 
            A versão sobrecarregada do método Math.Max() que chamamos aceitará int como os dois parâmetros de entrada e retornará o
            maior dos dois valores como um int.
             */
            int firstValuea = 500;
            int secondValuea = 600;
            int largerValuea;
            largerValuea = Math.Max(firstValuea, secondValuea);
            Console.WriteLine(largerValuea);





            ////Operadores logicos
            ///

            //Random dice = new Random();

            
            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if (total > 14)
            {
                Console.WriteLine("You win!");
            }

            if (total < 15)
            {
                Console.WriteLine("Sorry, you lose.");
            }


            /*
            Como retorna um valor de true ou false, message.Contains("fox") se qualifica como uma expressão booliana e pode ser usado em uma instrução if.

            Outras expressões boolianas simples podem ser criadas usando operadores para comparar dois valores. Os operadores incluem:

            ==, o "operador igual" para testar a igualdade
            >, o "operador maior que", para testar se o valor à esquerda é maior que o valor à direita
            <, o "operador menor que", para testar se o valor à esquerda é menor que o valor à direita
            >=, o "operador maior que ou igual a"
            <=, o "operador menor que ou igual a"
            E assim por diante             
             
             */


            string messageaa = "The quick brown fox jumps over the lazy dog.";
            bool result = messageaa.Contains("dog");
            Console.WriteLine(result);

            if (messageaa.Contains("fox"))
            {
                Console.WriteLine("What does the fox say?");
            }

            /*
    Os caracteres de pipe duplo || são o operador lógico OR, que basicamente afirma que "a expressão à minha esquerda OU a expressão à minha direita precisa ser verdadeira para que toda a expressão booliana seja verdadeira". Se as duas expressões boolianas forem falsas, a expressão booliana inteira será falsa. Usamos dois operadores lógicos OR para que possamos estender a avaliação para uma terceira expressão booliana.

    Primeiro, avaliamos (roll1 == roll2). Se for verdadeiro, a expressão inteira será verdadeira. Se for falso, avaliaremos (roll2 == roll3). Se for verdadeiro, a expressão inteira será verdadeira. Se for falso, avaliaremos (roll1 == roll3). Se for verdadeiro, a expressão inteira será verdadeira. Se for falso, a expressão inteira será falsa.

    Se a expressão booliana grande for verdadeira, executaremos o bloco de código abaixo. Desta vez, há duas linhas de código. A primeira linha de código imprime uma mensagem para o usuário. A segunda linha de código incrementa o valor de total em 2.

    Por fim, também alteramos a verificação para ver se o usuário venceu para usar o operador >=, o que se assemelha mais ao requisito que criamos quando começamos, mas deve funcionar de forma idêntica ao que escrevemos anteriormente.         
                 
    
            Os caracteres de E comercial duplos && são o operador lógico AND, que basicamente afirma que "somente se duas as expressões forem verdadeira, a expressão inteira será verdadeira". Nesse caso, se roll1 for igual a roll2, e roll2 for igual a roll3, por dedução, roll1 deverá ser igual a roll3 e o usuário teve um resultado triplicado.             
             
             */


            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired.");
            }
            else if (daysUntilExpiration == 1)
            {
                Console.WriteLine("Your subscription expires within a day!");
                discountPercentage = 20;
            }
            else if (daysUntilExpiration <= 5)
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
                discountPercentage = 10;
            }
            else if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon.  Renew now!");
            }

            if (discountPercentage > 0)
            {
                Console.WriteLine($"Renew now and save {discountPercentage}%.");
            }




            total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                total += 2;
            }

            if (total >= 15)
            {
                Console.WriteLine("You win!");
            }

            if (total < 15)
            {
                Console.WriteLine("Sorry, you lose.");
            }





            /*
                        Etapa 1: Declarar uma nova matriz
            Para declarar uma nova matriz de cadeias de caracteres para conter três elementos, digite a seguinte instrução C# no Editor do .NET.

            C#

            Copiar

            Executar

                        O operador new cria uma instância de uma matriz na memória do computador que pode conter três valores de cadeia de caracteres.Para saber mais sobre a palavra-chave new, confira o módulo "Chamar métodos da Biblioteca de Classes .NET usando C#".

            Observe que o primeiro conjunto de colchetes[] simplesmente indica ao compilador que a variável de nome fraudulentOrderIDs será uma matriz. No entanto, o segundo conjunto de colchetes[3] contém o número de elementos que a matriz conterá.
            */
            ///     tambem podera ser feito abaixo, ja inicializando com os valores
            ///     string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
            string[] fraudulentOrderIDs = new string[3];



            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";


            
            //recuperando os valores de uma matriz

            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
            // alterando o valor
            fraudulentOrderIDs[0] = "F000";
            // novo valor matriz
            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");


            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

            /*
           Executar um loop em uma matriz usando foreach
           A instrução foreach realiza um loop em cada elemento da matriz, 
           executando o bloco de código abaixo da declaração e substituindo o valor em uma variável 
           temporária pelo valor da matriz representada pelo loop atual.
           */

            string[] names = { "Bob", "Conrad", "Grant" };
            foreach (string nama in names)
            {
                Console.WriteLine(nama);
            }


            int[] inventory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            foreach (int items in inventory)
            {
                sum += items;
            }

            Console.WriteLine($"We have {sum} items in inventory.");

            int bin = 0;
            foreach (int items in inventory)
            {
                sum += items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} items (Running tally: {sum})");
            }
            Console.WriteLine($"We have {sum} items in inventory.");


            ////////////////////////////
            ///

            string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

            foreach (string orderID in orderIDs)
            {
                if (orderID.StartsWith("C"))
                {
                    Console.WriteLine(orderID);
                }
                if (orderID.StartsWith("B"))
                {
                    Console.WriteLine(orderID);
                }
            }



        }
    }



}