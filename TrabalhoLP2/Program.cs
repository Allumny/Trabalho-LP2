﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP2
{
    class Program
    {
        static void Main(string[] args)
        {
            {//separador das listas para reduzir a poluicão visual :)
            List<Aluno> ListAluno = new List<Aluno>();

            Aluno Aluno0 = new Aluno();
            Aluno Aluno1 = new Aluno();
            Aluno Aluno2 = new Aluno();
            Aluno Aluno3 = new Aluno();

            ListAluno.Add(Aluno0);
            ListAluno.Add(Aluno1);
            ListAluno.Add(Aluno2);
            ListAluno.Add(Aluno3);

            List<Professor> ListProfessor = new List<Professor>();

            Professor Professor0 = new Professor();
            Professor Professor1 = new Professor();
            Professor Professor2 = new Professor();
            Professor Professor3 = new Professor();

            ListProfessor.Add(Professor0);
            ListProfessor.Add(Professor1);
            ListProfessor.Add(Professor2);
            ListProfessor.Add(Professor3);

            List<Disciplina> ListDisciplina = new List<Disciplina>();

            Disciplina Disciplina0 = new Disciplina();
            Disciplina Disciplina1 = new Disciplina();
            Disciplina Disciplina2 = new Disciplina();
            Disciplina Disciplina3 = new Disciplina();

            ListDisciplina.Add(Disciplina0);
            ListDisciplina.Add(Disciplina1);
            ListDisciplina.Add(Disciplina2);
            ListDisciplina.Add(Disciplina3);

            List<Turma> ListTurma = new List<Turma>();

            Turma Turma0 = new Turma();
            Turma Turma1 = new Turma();
            Turma Turma2 = new Turma();
            Turma Turma3 = new Turma();

            ListTurma.Add(Turma0);
            ListTurma.Add(Turma1);
            ListTurma.Add(Turma2);
            ListTurma.Add(Turma3);
            }
            Console.Title = "Gerenciador de matrículas v1.0";
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();

            Console.WriteLine("Para alterar dados ou gerenciar");
            Console.WriteLine("alunos (1)");
            Console.WriteLine("professor (2)");
            Console.WriteLine("disciplina (3)");
            Console.WriteLine("turma (4)");
            Console.WriteLine("sair (0)");
            Console.WriteLine("Selecione a sua opcão:");
            Console.WriteLine();

            int op1, op2, op3;
            string respOstStr;
            int respOstInt;

            op1 = Convert.ToInt32(Console.ReadLine());
            if ((op1 > 4) (op1 < 0));
            {
                Console.WriteLine("Comando inválido.");
                Console.WriteLine("Digite sua opcão:");
                Console.WriteLine();
                op1 = Convert.ToInt32(Console.ReadLine());
            }

            if (op1 != 0);
            {
                if (op1 == 1)//aluno
                {
                    do
                    {
                        Console.WriteLine("Selecionado Aluno");
                        Console.WriteLine();
                        Console.WriteLine("Alunos registrados:");
                        Console.WriteLine();

                        for (int i = 0; i < 4; i++)
                        {
                            Console.Write("Aluno ("+ i +"): ");
                            if (ListAluno[i].getexisteAluno() == true)
                            {
                                Console.WriteLine(ListAluno[i].getNomeAluno());
                            }
                            else
                            {
                                Console.WriteLine("Dado não encontrado.");
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("Se deseja ler, registrar ou modificar os dados de um aluno digite o numero do aluno");
                        Console.WriteLine("Para sair digite 4");
                        Console.Write("Digite sua opcão: ");
                        op2 = Convert.ToInt32(Console.ReadLine());
                        

                        if(op2 == 4)
                        {
                            break;
                        }

                        if ((op2 >= 4) (op2 < 0))
                        {
                            Console.WriteLine("Comando inválido.");
                            Console.Write("Digite sua opcão: ");
                            op2 = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            for (int t = 0; t < 4; t++)
                            {
                                if (op2 == t)
                                {
                                    if (ListAluno[t].getexisteAluno() == false)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("O dado " + t + " ainda não foi registrado.");
                                        Console.WriteLine("Inserir dados novos: ");

                                        Console.Write("Nome do aluno: ");
                                        respOstStr = Console.ReadLine();
                                        ListAluno[t].setNomeAluno(respOstStr);

                                        Console.Write("Número na chamada: ");
                                        respOstInt = Convert.ToInt32(Console.ReadLine());
                                        ListAluno[t].setNumAluno(respOstInt);
                                        ListAluno[t].setexisteAluno(true);

                                        Console.Write("Matrícula: ");
                                        respOstStr = Console.ReadLine();
                                        ListAluno[t].setMatAluno(respOstStr);

                                        Console.Write("Idade do aluno: ");
                                        respOstInt = Convert.ToInt32(Console.ReadLine());
                                        ListAluno[t].setIdadeAluno(respOstInt);

                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Dados do aluno (" + t + "):");
                                        Console.WriteLine("Nome do aluno: " + ListAluno[t].getNomeAluno() + " (1)");
                                        Console.WriteLine("Numero do aluno: " + ListAluno[t].getNumAluno() + " (2)");
                                        Console.WriteLine("Matricula do aluno: " + ListAluno[t].getMatAluno() + " (3)");
                                        Console.WriteLine("Idade do aluno: " + ListAluno[t].getIdadeAluno() + " (4)");

                                        Console.WriteLine();
                                        Console.WriteLine("Se deseja alterar os dados de " + ListAluno[t].getNomeAluno() + ", escolha a opcão que desejar.");
                                        Console.WriteLine("Se deseja sair digite 0");
                                        Console.WriteLine("Digite sua opcão: ");
                                        op3 = Convert.ToInt32(Console.ReadLine());

                                        while((op3 > 4) (op3 < 0))
                                        {
                                            Console.WriteLine("Comando inválido.");
                                            Console.WriteLine("Digite sua opcão: ");
                                            op3 = Convert.ToInt32(Console.ReadLine());
                                        }

                                        if(op3 == 1)
                                        {
                                            Console.Write("Nome do aluno: ");
                                            respOstStr = Console.ReadLine();
                                            ListAluno[t].setNomeAluno(respOstStr);
                                        }
                                        else if(op3 == 2)
                                        {
                                            Console.Write("Número na chamada: ");
                                            respOstInt = Convert.ToInt32(Console.ReadLine());
                                            ListAluno[t].setNumAluno(respOstInt);
                                        }
                                        else if(op3 == 3)
                                        {
                                            Console.Write("Matrícula: ");
                                            respOstStr = Console.ReadLine();
                                            ListAluno[t].setMatAluno(respOstStr);
                                        }
                                        else if(op3 == 4)
                                        {
                                            Console.Write("Idade do aluno: ");
                                            respOstInt = Convert.ToInt32(Console.ReadLine());
                                            ListAluno[t].setIdadeAluno(respOstInt);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    while (op2 != 4);                   
                }

                if (op1 == 2)//professor
                {
                    do
                    {
                        Console.WriteLine("Selecionado Professor");
                        Console.WriteLine();
                        Console.WriteLine("Professores registrados:");
                        Console.WriteLine();

                        for (int i = 0; i < 4; i++)
                        {
                            Console.Write("Professor ("+ i +"): ");
                            if (ListProfessor[i].getexisteProfessor() == true)
                            {
                                Console.WriteLine(ListProfessor[i].getNomeProfessor());
                            }
                            else
                            {
                                Console.WriteLine("Dado não encontrado.");
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("Se deseja ler, registrar ou modificar os dados de um professor digite o numero do mesmo");
                        Console.WriteLine("Para sair digite 4");
                        Console.Write("Digite sua opcão: ");
                        op2 = Convert.ToInt32(Console.ReadLine());
                        

                        if(op2 == 4)
                        {
                            break;
                        }

                        if ((op2 >= 4) (op2 < 0))
                        {
                            Console.WriteLine("Comando inválido.");
                            Console.Write("Digite sua opcão: ");
                            op2 = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            for (int t = 0; t < 4; t++)
                            {
                                if (op2 == t)
                                {
                                    if (ListProfessor[t].getexisteProfessor() == false)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("O dado " + t + " ainda não foi registrado.");
                                        Console.WriteLine("Inserir dados novos: ");

                                        Console.Write("Nome do professor: ");
                                        respOstStr = Console.ReadLine();
                                        ListProfessor[t].setNomeProfessor(respOstStr);

                                        Console.Write("Número na chamada: ");
                                        respOstInt = Convert.ToInt32(Console.ReadLine());
                                        ListAluno[t].setNumAluno(respOstInt);
                                        ListAluno[t].setexisteAluno(true);

                                        Console.Write("Matrícula: ");
                                        respOstStr = Console.ReadLine();
                                        ListAluno[t].setMatAluno(respOstStr);

                                        Console.Write("Idade do aluno: ");
                                        respOstInt = Convert.ToInt32(Console.ReadLine());
                                        ListAluno[t].setIdadeAluno(respOstInt);

                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Dados do aluno (" + t + "):");
                                        Console.WriteLine("Nome do aluno: " + ListAluno[t].getNomeAluno() + " (1)");
                                        Console.WriteLine("Numero do aluno: " + ListAluno[t].getNumAluno() + " (2)");
                                        Console.WriteLine("Matricula do aluno: " + ListAluno[t].getMatAluno() + " (3)");
                                        Console.WriteLine("Idade do aluno: " + ListAluno[t].getIdadeAluno() + " (4)");

                                        Console.WriteLine();
                                        Console.WriteLine("Se deseja alterar os dados de " + ListAluno[t].getNomeAluno() + ", escolha a opcão que desejar.");
                                        Console.WriteLine("Se deseja sair digite 0");
                                        Console.WriteLine("Digite sua opcão: ");
                                        op3 = Convert.ToInt32(Console.ReadLine());

                                        while((op3 > 4) (op3 < 0))
                                        {
                                            Console.WriteLine("Comando inválido.");
                                            Console.WriteLine("Digite sua opcão: ");
                                            op3 = Convert.ToInt32(Console.ReadLine());
                                        }

                                        if(op3 == 1)
                                        {
                                            Console.Write("Nome do aluno: ");
                                            respOstStr = Console.ReadLine();
                                            ListAluno[t].setNomeAluno(respOstStr);
                                        }
                                        else if(op3 == 2)
                                        {
                                            Console.Write("Número na chamada: ");
                                            respOstInt = Convert.ToInt32(Console.ReadLine());
                                            ListAluno[t].setNumAluno(respOstInt);
                                        }
                                        else if(op3 == 3)
                                        {
                                            Console.Write("Matrícula: ");
                                            respOstStr = Console.ReadLine();
                                            ListAluno[t].setMatAluno(respOstStr);
                                        }
                                        else if(op3 == 4)
                                        {
                                            Console.Write("Idade do aluno: ");
                                            respOstInt = Convert.ToInt32(Console.ReadLine());
                                            ListAluno[t].setIdadeAluno(respOstInt);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    while (op2 != 4);                   
                }

                Console.Title = "Gerenciador de matrículas v1.0";
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.Clear();    
                Console.WriteLine("Para alterar dados ou gerenciar {0}");
                Console.WriteLine("alunos (1)");
                Console.WriteLine("professor (2)");
                Console.WriteLine("disciplina (3)");
                Console.WriteLine("turma (4)");
                Console.WriteLine("sair (0)");
                Console.WriteLine("Selecione a sua opcão:");
                Console.WriteLine();

                op1 = Convert.ToInt32(Console.ReadLine());
                while (op1 > 4 || op1 < 0)
                {
                    Console.WriteLine("Numero invalido!");
                    Console.WriteLine("Digite sua opção: ");
                    resp1 = Convert.ToInt32(Console.ReadLine());
                }
            }


        }

        class Aluno
        {

            string nomeAluno;
            bool existeAluno = false;
            int numAluno;
            string matAluno;
            int idadeAluno;

            public void setNomeAluno(string VarNomeAluno)
            {
                this.nomeAluno = VarNomeAluno;
            }

            public string getNomeAluno()
            {
                return nomeAluno;
            }

            public void setexisteAluno(bool VarexisteAluno)
            {
                this.existeAluno = VarexisteAluno;
            }

            public bool getexisteAluno()
            {
                return existeAluno;
            }

            public void setNumAluno(int VarNumAluno)
            {
                this.numAluno = VarNumAluno;
            }

            public int getNumAluno()
            {
                return numAluno;
            }

            public void setMatAluno(string VarMatAluno)
            {
                this.matAluno = VarMatAluno;
            }

            public string getMatAluno()
            {
                return matAluno;
            }

            public void setIdadeAluno(int VarIdadeAluno)
            {
                this.idadeAluno = VarIdadeAluno;
            }

            public int getIdadeAluno()
            {
                return idadeAluno;
            }
        }

        class Professor
        {

            string nomeProf;
            bool existeProf = false;
            int idadeProf;
            string mateProf;
            int quantTempAulaProf;

            public void setNomeProf(string VarNomeProf)
            {
                this.nomeProf = VarNomeProf;
            }

            public string getNomeProf()
            {
                return nomeProf;
            }

            public void setexisteProf(bool VarexisteProf)
            {
                this.existeProf = VarexisteProf;
            }

            public bool getexisteProf()
            {
                return existeProf;
            }

            public void setMateProf(string VarMateProf)
            {
                this.mateProf = VarMateProf;
            }

            public string getMateProf()
            {
                return mateProf;
            }

            public void setQuantTempAulaProf(int VarQuantTempAulaProf)
            {
                this.quantTempAulaProf = VarQuantTempAulaProf;
            }

            public int getQuantTempAulaProf()
            {
                return quantTempAulaProf;
            }

            public void setIdadeProf(int VarIdadeProf)
            {
                this.idadeProf = VarIdadeProf;
            }

            public int getIdadeProf()
            {
                return idadeProf;
            }
        }

        class Disciplina
        {

            string nomeDisc;
            bool existeDisc = false;
            string nomeCoordDisc;
            int tempAulaDisc;
            bool aulaTodoDiaDisc;

            public void setNomeDisc(string VarNomeDisc)
            {
                this.nomeDisc = VarNomeDisc;
            }

            public string getNomeDisc()
            {
                return nomeDisc;
            }

            public void setexisteDisc(bool VarexisteDisc)
            {
                this.existeDisc = VarexisteDisc;
            }

            public bool getexisteDisc()
            {
                return existeDisc;
            }

            public void setNomeCoordDisc(string VarNomeCoordDisc)
            {
                this.nomeCoordDisc = VarNomeCoordDisc;
            }

            public string getNomeCoordDisc()
            {
                return nomeCoordDisc;
            }

            public void setTempAulaDisc(int VarTempAulaDisc)
            {
                this.tempAulaDisc = VarTempAulaDisc;
            }

            public int getTempAulaDisc()
            {
                return tempAulaDisc;
            }

            public void setAulaTodoDiaDisc(bool VarAulaTodoDiaDisc)
            {
                this.aulaTodoDiaDisc = VarAulaTodoDiaDisc;
            }

            public bool getAulaTodoDiaDisc()
            {
                return aulaTodoDiaDisc;
            }

        }

        class Turma
        {

            string salaTurma;
            bool existeTurma = false;
            int numTurma;
            int quantAlunTurma;
            int quantTempAulaTurma;

            public void setSalaTurma(string VarSalaTurma)
            {
                this.salaTurma = VarSalaTurma;
            }

            public string getSalaTurma()
            {
                return salaTurma;
            }

            public void setexisteTurma(bool VarexisteTurma)
            {
                this.existeTurma = VarexisteTurma;
            }

            public bool getexisteTurma()
            {
                return existeTurma;
            }

            public void setNumTurma(int VarNumTurma)
            {
                this.numTurma = VarNumTurma;
            }

            public int getNumTurma()
            {
                return numTurma;
            }

            public void setQuantAlunTurma(int VarQuantAlunTurma)
            {
                this.quantAlunTurma = VarQuantAlunTurma;
            }

            public int getQuantAlunTurma()
            {
                return quantAlunTurma;
            }

            public void setQuantTempAulaTurma(int VarQuantTempAulaTurma)
            {
                this.quantTempAulaTurma = VarQuantTempAulaTurma;
            }

            public int getQuantTempAulaTurma()
            {
                return quantTempAulaTurma;
            }

        }
    }
}
