using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    internal class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            Matematica m = new Matematica(10, 20);
            m.Somar();


            /*Operacao op = Calculadora.Somar; 
            Operacao op = new Operacao(Calculadora.Somar);
            op += Calculadora.Subtrair;

            op.Invoke( 10, 10); 
 
            Data data = new Data();
            //data.SetMes(20);

            data.Mes = 12;
            //Console.WriteLine(data.Mes);

            data.ApresentarMes();
 
             Log log = Log.GetInstance();
            log.PropriedadeLog = "Teste instancia";

            Log log2 = Log.GetInstance();
            Console.WriteLine(log2.PropriedadeLog);
 
            
             Aluno p1 = new Aluno("Lucas", "Adati","Teste");
            p1.Apresentar();*/
        }
    }
}

