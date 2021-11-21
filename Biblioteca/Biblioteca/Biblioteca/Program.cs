using System;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Funções de texto

            //Trim
            //Retira todos os espaços em branco antes e depois de uma expressão.
            //Os espaços existentes no meio da expressão são mantidos.
            string empresa = " Microsoft Corporation ";
            string empresaSemEspaco = empresa.Trim();
            
            Console.WriteLine("Trim");
            Console.WriteLine($"Nome da Empresa:{empresa}");
            Console.WriteLine($"Nome da Empresa:{empresaSemEspaco}");

            //Length
            //Conta a quantidade de caracteres da expressão, incluindo os espaços em branco em toda a expressão.
            string empresa = " Microsoft Corporation ";
            string empresaSemEspaco = empresa.Trim();
            
            Console.WriteLine("Length");
            Console.WriteLine($"Tamanho do texto: {empresa.Length}");
            Console.WriteLine($"Tamanho após TRIM: {empresaSemEspaco.Length}");

            //ToUpper
            //Transforma toda a expressão em letras maiúsculas.
            string empresa = "Microsoft Corporation";
            string empresaMaiuscula = empresa.ToUpper();
            
            Console.WriteLine("ToUpper");
            Console.WriteLine($"Texto em maiúsculo: {empresaMaiuscula}");

            //ToLower
            //Transform toda a expressão em letras minúsculas.
            string empresa = "Microsoft Corporation";
            string empresaMinuscula = empresa.ToLower();
            
            Console.WriteLine("ToLower");
            Console.WriteLine($"Texto em minúsculo: {empresaMinuscula}");

            //Remove
            //Serve para capturar uma quantidade de caracteres à esquerda de uma expressão.
            //Por exemplo, ler apenas os primeiros 11 caracteres.
            string empresa = "Microsoft Corporation";
            string empresaRecortada = empresa.Remove(11);
            
            Console.WriteLine("Remove");
            Console.WriteLine($"Empresa 11 caracteres: {empresaRecortada}");

            //Pegar somente o primeiro nome (até o espaço, sem incluí-lo).
            string empresa = "Microsoft Corporation";
            int posicaoEspaco = empresa.IndexOf(" ");
            string empresaRecortada = empresa.Remove(posicaoEspaco);
            Console.WriteLine($"Primeiro nome Empresa: {empresaRecortada}");

            //Substring
            //Usado para extrair parte do texto a partir de uma posição inicial.
            //O tamanho do texto a ser capturado pode ou não ser informado.

            string empresa = "Microsoft Corporation";
            int posicaoEspaco = empresa.IndexOf(" ");
            string empresaSegundoNome = empresa.Substring(posicaoEspaco);
            string empresaRecortada = empresa.Substring(posicaoEspaco, 6);
            
            Console.WriteLine("Substring");
            Console.WriteLine($"Segundo nome Empresa: {empresaSegundoNome}");
            Console.WriteLine($"Empresa recortada: {empresaRecortada}");

            //IsNullOrEmpty
            //Verifica se uma String está nula ou vazia.
            //Muito usado para consistência de dados onde há interação com quem usa o software.
            string nome = "Flávia";
            string sobrenome = null;
            
            Console.WriteLine("IsNullOrEmpty");
            if (!String.IsNullOrEmpty(nome) && !String.IsNullOrEmpty(sobrenome))
            {
                Console.WriteLine($"Nome completo: {nome} {sobrenome}");
            }
            else
            {
                Console.WriteLine($"Nome: {nome}");
            }

            //Split
            //O método Split é muito usado em situações de tratamento de dados oriundos de arquivos textos, CSV, Excel,
            //onde é preciso separar as cadeias de caracteres através de um caractere chave.
            string empresa = "Microsoft Corporation MSFT";
            string[] empresaPartes = empresa.Split(' ');
            
            Console.WriteLine("Split");
            foreach (var parte in empresaPartes)
            {
                Console.WriteLine(parte);
            }

            // Coleções
            //Estruturas de dados que podemos criar ou gerenciar quando queremos definir objetos e utilizar os mesmos em nossos sistemas.

            int[] primeiraArray = new int[100];
            int[] segundaArray = new int[]{ 1, 3, 5, 7, 9 };
            int[] terceiraArray = { 1, 3, 5, 7, 9 };
            
            Console.WriteLine("Array");
            Console.WriteLine($"Item 3: {segundaArray[2]}");

            //As listas no C# têm a finalidade de armazenar um tipo de dados no sistema.
            //Esses tipos de dados comumente são denominados como listas tipadas:
            //ao criar uma lista com um tipo de dados string, todos os valores daquela lista devem ser de fato uma string.
            List<string> listaChamada = new List<string>();
            listaChamada.Add("Ana Clara");
            listaChamada.Add("Bianca");
            listaChamada.Add("Cléia");
            
            Console.WriteLine("Listas");
            foreach(string nome in listaChamada)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
