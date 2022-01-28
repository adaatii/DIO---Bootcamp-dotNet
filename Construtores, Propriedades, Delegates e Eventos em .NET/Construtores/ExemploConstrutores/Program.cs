using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Data data = new Data();
            //data.SetMes(20);

            data.Mes = 12;
            //Console.WriteLine(data.Mes);

            data.ApresentarMes();

           /*  Log log = Log.GetInstance();
            log.PropriedadeLog = "Teste instancia";

            Log log2 = Log.GetInstance();
            Console.WriteLine(log2.PropriedadeLog);
 */
            
            /* Aluno p1 = new Aluno("Lucas", "Adati","Teste");
            p1.Apresentar();   */
        }
    }
}

