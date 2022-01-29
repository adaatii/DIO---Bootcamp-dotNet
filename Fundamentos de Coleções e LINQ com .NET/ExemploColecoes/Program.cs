using ExemploColecoes.helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] {6, 3, 1, 9, 10};
            int[] arrayCopia = new int[10];   
            string[] arrayDeString = op.ConverterArrayString(array);      

            //int valorProcurado = 9;

            System.Console.WriteLine($"Capacidade atual: {array.Length}");

            op.RedimensionarArray(ref array, array.Length*2);

            System.Console.WriteLine($"Capacidade atual após redimensionar: {array.Length}");
             


            // int indice = op.ObterIndice(array, valorProcurado);

            // if (indice > -1)
            // {
            //     System.Console.WriteLine($"O indice do elemento {valorProcurado} é: {indice}");
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor não existente no array");
            // }
            
            // int valorAchado = op.ObterValor(array, valorProcurado);


            // if (valorAchado > 0)
            // {
            //      System.Console.WriteLine("Encontrei o valor");
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor");
            // }



            // bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            // if (todosMaiorQue)
            // {
            //     System.Console.WriteLine($"Todos os valores são maiores que: {valorProcurado}");
            // }
            // else
            // {
            //     System.Console.WriteLine($"Algum valor é menor que: {valorProcurado}");
            // }

            // bool existe = op.Existe(array, valorProcurado);

            // if (existe)
            // {
            //     System.Console.WriteLine($"Encontrei o valor {valorProcurado}");
            // }
            // else
            // {
            //     System.Console.WriteLine($"Não encontrei o valor {valorProcurado}");
            // }


            //System.Console.WriteLine("Array original");
            //op.ImprimirArray(array);

            //op.OrdenarBublleSort(ref array);
            //op.Ordernar(ref array);

            //System.Console.WriteLine("Array ordenado");
            //op.ImprimirArray(array);

            // System.Console.WriteLine("Array antes da cópia");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array depois da cópia");
            // op.ImprimirArray(arrayCopia);

            // int[,] matriz = new int[4,2]
            // {
            //     {8, 8},
            //     {10, 20},
            //     {50, 100},
            //     {90, 200}
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matriz[i,j]);
            //     }
            // }



            // int[] arrayinteiros = new int[3];
            // arrayinteiros[0]= 10;
            // arrayinteiros[1]= 20;
            // arrayinteiros[2]= 30;


            // System.Console.WriteLine("Percorrendo array pelo for");
            // for (int i = 0; i < arrayinteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayinteiros[i]);
            // }
            
            // System.Console.WriteLine("Percorrendo array pelo foreach");
            // foreach (var item in arrayinteiros)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}