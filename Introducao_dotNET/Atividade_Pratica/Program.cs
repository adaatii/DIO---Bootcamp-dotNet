﻿using System;

namespace Atividade_Pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string? opcaoUsuario = obterOpcaoUsuario();

            while (opcaoUsuario?.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: adicionar aluno.
                        Console.WriteLine("Informe o nome do aluno");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {                            
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;           

                        break;

                    case "2":
                        //TODO: listar alunos.
                        
                        foreach (var b in alunos)
                        {
                            if (!string.IsNullOrEmpty(b.Nome)){
                                Console.WriteLine($"ALUNO: {b.Nome}  -  NOTA: {b.Nota}");
                            }                           
                                                   
                        }
                        break;
                    case "3":
                        //TODO:calcular média
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = obterOpcaoUsuario();
            }
        }

        private static string? obterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1-Inserir novo aluno");
            Console.WriteLine("2-Listar alunos");
            Console.WriteLine("3-Calcular média geral");
            Console.WriteLine("X-Sair");
            Console.WriteLine();
        
            string? opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
