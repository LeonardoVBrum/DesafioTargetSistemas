
        Console.Write("Digite uma string para ser invertida: ");
        string entrada = Console.ReadLine();

     
        char[] caracteres = entrada.ToCharArray();

 
        string invertida = "";
        for (int i = caracteres.Length - 1; i >= 0; i--)
        {
            invertida += caracteres[i];
        }

   
        Console.WriteLine("String invertida: " + invertida);