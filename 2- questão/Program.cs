/* 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre 
/será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), 
/escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci 
/e retorne uma mensagem avisando se o número informado pertence ou não a sequência.*/


 Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());

        // Inicializa os dois primeiros números da sequência de Fibonacci
        int a = 0, b = 1;
        bool pertence = false;

        // Verifica se o número informado é 0 ou 1
        if (numero == 0 || numero == 1)
        {
            pertence = true;
        }
        else
        {
            // Gera a sequência de Fibonacci até que o número informado seja alcançado ou ultrapassado
            while (b <= numero)
            {
                if (b == numero)
                {
                    pertence = true;
                    break;
                }
                int temp = b;
                b = a + b; // Próximo número da sequência
                a = temp;  // Atualiza 'a' para o próximo valor
            }
        }

        // Retorna a mensagem ao usuário
        if (pertence)
        {
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
        }
    