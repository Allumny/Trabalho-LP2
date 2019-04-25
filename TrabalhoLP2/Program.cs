using System;
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
            Console.BackgroundColor = ConsoleColor.White;
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
                break;
            }
            //aluno
            if (op1 == 1)
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
                            if (ListAluno[i].getExisteAluno() == true)
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
                                    if (ListAluno[t].getExisteAluno() == false)
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
                                        ListAluno[t].setExisteAluno(true);

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
            //professor
            if (op1 == 2)
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
                                    if (ListProfessor[t].getExisteProfessor() == false)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("O dado " + t + " ainda não foi registrado.");
                                        Console.WriteLine("Inserir dados novos: ");

                                        Console.Write("Nome do professor: ");
                                        respOstStr = Console.ReadLine();
                                        ListProfessor[t].setNomeProfessor(respOstStr);

                                        Console.Write("Número de Aulas por semana: ");
                                        respOstInt = Convert.ToInt32(Console.ReadLine());
                                        ListProfessor[t].setNumProfessor(respOstInt);
                                        ListProfessor[t].setExisteProfessor(true);

                                        Console.Write("Matrícula: ");
                                        respOstStr = Console.ReadLine();
                                        ListProfessor[t].setMatProfessor(respOstStr);

                                        Console.Write("Idade do professor: ");
                                        respOstInt = Convert.ToInt32(Console.ReadLine());
                                        ListProfessor[t].setIdadeProfessor(respOstInt);

                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Dados do aluno (" + t + "):");
                                        Console.WriteLine("Nome do professor: " + ListProfessor[t].getNomeProfessor() + " (1)");
                                        Console.WriteLine("Número de Aulas por semana: " + ListProfessor[t].getNumProfessor() + " (2)");
                                        Console.WriteLine("Matricula: " + ListProfessor[t].getMatProfessor() + " (3)");
                                        Console.WriteLine("Idade do professor: " + ListProfessor[t].getIdadeProfessor() + " (4)");

                                        Console.WriteLine();
                                        Console.WriteLine("Se deseja alterar os dados de " + ListProfessor[t].getNomeProfessor() + ", escolha a opcão que desejar.");
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
                                            Console.Write("Nome do professor: ");
                                            respOstStr = Console.ReadLine();
                                            ListProfessor[t].setNomeProfessor(respOstStr);
                                        }
                                        else if(op3 == 2)
                                        {
                                            Console.Write("Número de Aulas por semana: ");
                                            respOstInt = Convert.ToInt32(Console.ReadLine());
                                            ListProfessor[t].setNumProfessor(respOstInt);
                                        }
                                        else if(op3 == 3)
                                        {
                                            Console.Write("Matrícula: ");
                                            respOstStr = Console.ReadLine();
                                            ListProfessor[t].setMatProfessor(respOstStr);
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
            //disciplina
            if (op1 == 3)
                {
                    do
                    {
                        Console.WriteLine("Selecionado Disciplina");
                        Console.WriteLine();
                        Console.WriteLine("Disciplinas registradas:");
                        Console.WriteLine();

                        for (int i = 0; i < 4; i++)
                        {
                            Console.Write("Disciplina " + i + ": ");
                            if (ListDisciplina[i].getExisteDisciplina() == true)
                            {
                                Console.WriteLine(ListDisciplina[i].getNomeDisciplina());
                            }
                            else
                            {
                                Console.WriteLine("Dado não encontrado.");
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("Se desejar ler, registrar ou modificar os dados de uma Disciplina digite o numero da mesma");
                        Console.WriteLine("Para sair digite 4");
                        Console.Write("Digite sua opcão: ");
                        op2 = Convert.ToInt32(Console.ReadLine());

                        while (op2 > 4 || op2 < 0)
                        {
                            Console.WriteLine("Numero inválido.");
                            Console.WriteLine("Digite sua opcão: ");
                            op2 = Convert.ToInt32(Console.ReadLine());
                        }

                        if (op2 == 4)
                        {
                            break;
                        }

                        for (int t = 0; t < 4; t++)
                        {
                            if (op2 == t)
                            {
                                if (ListDisciplina[t].getExisteDisciplina() == false)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Os dados da Disciplina " + t + " ainda não foram registrados");
                                    Console.WriteLine("Digite as novas informacões");

                                    Console.Write("Digite o nome da disciplina: ");
                                    ListDisciplina[t].setNomeDisciplina(Console.ReadLine());

                                    Console.Write("Digite o nome do professor coodernador: ");
                                    ListDisciplina[t].setNomeCoordDisciplina(Console.ReadLine());

                                    Console.Write("Digite se é obrigatorio ter aula todo dia dessa disciplina: ");
                                    Console.WriteLine("Digite 1 para obrigatorio, ou 0 para não obrigatorio: ");
                                    respOstInt = Convert.ToInt32(Console.ReadLine());
                                    while (respOstInt != 0 || respOstInt != 0){
                                        Console.WriteLine("Comando inválido.");
                                        Console.Write("Digite 1 para obrigatorio, ou 0 para não obrigatorio: ");
                                        respOstInt = Convert.ToInt32(Console.ReadLine());
                                    }
                                    if(respOstInt == 1)
                                    {
                                        ListDisciplina[t].setAulaTodoDiaDisciplina(true);
                                    }
                                    else
                                    {
                                        ListDisciplina[t].setAulaTodoDiaDisciplina(false);
                                    }

                                    Console.Write("Digite quantos tempos são dados por semana: ");
                                    ListDisciplina[t].setTempAulaDisciplina(Convert.ToInt32(Console.ReadLine()));

                                    ListDisciplina[t].setexisteDisciplina(true);

                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Dados da disciplina " + t);
                                    Console.WriteLine("Nome da disciplina: " + ListDisciplina[t].getNomeDisciplina() + " opcão 1");
                                    Console.WriteLine("Nome do professor coodernador: " + ListDisciplina[t].getNomeCoordDisciplina() + " opcão 2");
                                    Console.WriteLine("Aula todo dia: " + ListDisciplina[t].getAulaTodoDiaDisciplina() + " opcão 3");
                                    Console.WriteLine("Quantos tempos são dados por semana: " + ListDisciplina[t].getTempAulaDisciplina() + " opcão 4");

                                    Console.WriteLine();
                                    Console.WriteLine("Se deseja modificar dados de " + ListDisciplina[t].getNomeDisciplina() + ", escolha a opção do dado");
                                    Console.WriteLine("Se deseja sair digite 0");
                                    Console.WriteLine("Digite sua opcão: ");
                                    op3 = Convert.ToInt32(Console.ReadLine());

                                    while (op3 > 4 || op3 < 0)
                                    {
                                        Console.WriteLine("Opção inválida.");
                                        Console.WriteLine("Digite sua opcão: ");
                                        op3 = Convert.ToInt32(Console.ReadLine());
                                    }

                                    if (op3 == 1)
                                    {
                                        Console.Write("Digite o nome da disciplina: ");
                                        ListDisciplina[t].setNomeDisciplina(Console.ReadLine());
                                    }
                                    else if (op3 == 2)
                                    {
                                        Console.Write("Digite o nome do professor coodernador: ");
                                        ListDisciplina[t].setNomeCoordDisciplina(Console.ReadLine());
                                    }
                                    else if (op3 == 3)
                                    {
                                        Console.Write("Digite se é obrigatorio ter aula todo dia dessa disciplina: ");
                                        Console.WriteLine("Digite 1 para obrigatorio, ou 0 para não obrigatorio: ");
                                        respOstInt = Convert.ToInt32(Console.ReadLine());
                                        while (respOstInt != 0 || respOstInt != 0)
                                        {
                                            Console.WriteLine("Comando inválido.");
                                            Console.Write("Digite 1 para obrigatorio, ou 0 para não obrigatorio: ");
                                            respOstInt = Convert.ToInt32(Console.ReadLine());
                                        }
                                        if (respOstInt == 1)
                                        {
                                            ListDisciplina[t].setAulaTodoDiaDisciplina(true);
                                        }
                                        else
                                        {
                                            ListDisciplina[t].setAulaTodoDiaDisciplina(false);
                                        }
                                    }
                                    else if (op3 == 4)
                                    {
                                        Console.Write("Digite quantos tempos são dados por semana: ");
                                        ListDisciplina[t].setTempAulaDisciplina(Convert.ToInt32(Console.ReadLine()));
                                    }

                                }
                            }
                        }
                    } while (op2 != 4);
                }
            //turma
            if (op1 == 4)
                {
                    do
                    {
                        Console.WriteLine("Selecionado Turma");
                        Console.WriteLine();
                        Console.WriteLine("Turmas registradas:");
                        Console.WriteLine();

                        for (int i = 0; i < 4; i++)
                        {
                            Console.Write("Turma " + i + ": ");
                            if (ListTurma[i].getExisteTurma() == true)
                            {
                                Console.WriteLine(ListTurma[i].getNumTurma());
                            }
                            else
                            {
                                Console.WriteLine("não registrado");
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("Se deseja ler, registrar ou modificar os dados de uma turma digite o numero da opcão da mesma");
                        Console.WriteLine("Se deseja sair digite 4");
                        Console.Write("Digite a opcão: ");
                        op2 = Convert.ToInt32(Console.ReadLine());

                        while (op2 > 4 || op2 < 0)
                        {
                            Console.WriteLine("Comando inválido.");
                            Console.WriteLine("Digite o numero da opção: ");
                            op2 = Convert.ToInt32(Console.ReadLine());
                        }

                        if (op2 == 4)
                        {
                            break;
                        }

                        for (int t = 0; t < 4; t++)
                        {
                            if (op2 == t)
                            {
                                if (ListTurma[t].getExisteTurma() == false)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Os dados da turma " + t + " ainda não foram registrados");
                                    Console.WriteLine("Digite os dados dela");

                                    Console.Write("Digite o numero da turma: ");
                                    ListTurma[t].setNumTurma(Convert.ToInt32(Console.ReadLine()));

                                    Console.Write("Digite o numero de alunos: ");
                                    ListTurma[t].setQuantAlunTurma(Convert.ToInt32(Console.ReadLine()));

                                    Console.Write("Digite a sala da turma: ");
                                    ListTurma[t].setSalaTurma(Console.ReadLine());

                                    Console.Write("Digite quantos tempos de aula a turma tem por dia: ");
                                    ListTurma[t].setQuantTempAulaTurma(Convert.ToInt32(Console.ReadLine()));

                                    ListTurma[t].setExisteTurma(true);

                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Dados da turma " + t );
                                    Console.WriteLine("Numero da turma: " + ListTurma[t].getNumTurma() + " opcão 1");
                                    Console.WriteLine("Numero de alunos: " + ListTurma[t].getQuantAlunTurma() + " opcão 2");
                                    Console.WriteLine("Sala da turma: " + ListTurma[t].getSalaTurma() + " opcão 3");
                                    Console.WriteLine("Quantos tempos de aula a turma tem por dia: " + ListTurma[t].getQuantTempAulaTurma() + " opcão 4");

                                    Console.WriteLine();
                                    Console.WriteLine("Se deseja modificar dados de " + ListTurma[t].getNumTurma() + ", escolha a opcão do dado");
                                    Console.WriteLine("Se deseja sair digite 0");
                                    Console.WriteLine("Digite sua opcão: ");
                                    op3 = Convert.ToInt32(Console.ReadLine());

                                    while (op3 > 4 || op3 < 0)
                                    {
                                        Console.WriteLine("Opcão invalida.");
                                        Console.WriteLine("Digite sua opcão: ");
                                        op3 = Convert.ToInt32(Console.ReadLine());
                                    }

                                    if (op3 == 1)
                                    {

                                        Console.Write("Digite o numero da turma: ");
                                        ListTurma[t].setNumTurma(Convert.ToInt32(Console.ReadLine()));
                                    }
                                    else if (op3 == 2)
                                    {
                                        Console.Write("Digite o numero de alunos: ");
                                        ListTurma[t].setQuantAlunTurma(Convert.ToInt32(Console.ReadLine()));
                                    }
                                    else if (op3 == 3)
                                    {
                                        Console.Write("Digite a sala da turma: ");
                                        ListTurma[t].setSalaTurma(Console.ReadLine());
                                    }
                                    else if (op3 == 4)
                                    {
                                        Console.Write("Digite quantos tempos de aula a turma tem por dia: ");
                                        ListTurma[t].setQuantTempAulaTurma(Convert.ToInt32(Console.ReadLine()));
                                    }

                                }
                            }
                        }


                    } while (op2 != 4);
                }


                Console.Title = "Gerenciador de matrículas v1.0";
                Console.BackgroundColor = ConsoleColor.White;
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
                    Console.WriteLine("Comando inválido.");
                    Console.WriteLine("Digite sua opção: ");
                    resp1 = Convert.ToInt32(Console.ReadLine());
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

            public void setExisteAluno(bool VarExisteAluno)
            {
                this.existeAluno = VarExisteAluno;
            }

            public bool getExisteAluno()
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

            string nomeProfessor;
            bool existeProfessor = false;
            int idadeProfessor;
            string matProfessor;
            int numProfessor;

            public void setNomeProfessor(string VarNomeProfessor)
            {
                this.nomeProfessor = VarNomeProfessor;
            }

            public string getNomeProfessor()
            {
                return nomeProfessor;
            }

            public void setExisteProfessor(bool VarExisteProfessor)
            {
                this.existeProfessor = VarExisteProfessor;
            }

            public bool getExisteProfessor()
            {
                return existeProfessor;
            }

            public void setMatProfessor(string VarMatProfessor)
            {
                this.matProfessor = VarMatProfessor;
            }

            public string getMatProfessor()
            {
                return matProfessor;
            }

            public void setNumProfessor(int VarNumProfessor)
            {
                this.numProfessor = VarNumProfessor;
            }

            public int getNumProfessor()
            {
                return numProfessor;
            }

            public void setIdadeProfessor(int VarIdadeProfessor)
            {
                this.idadeProfessor = VarIdadeProfessor;
            }

            public int getIdadeProfessor()
            {
                return idadeProfessor;
            }
        }

        class Disciplina
        {

            string nomeDisciplina;
            bool existeDisciplina = false;
            string nomeCoordDisciplina;
            int tempAulaDisciplina;
            bool aulaTodoDiaDisciplina;

            public void setNomeDisciplina(string VarNomeDisciplina)
            {
                this.nomeDisciplina = VarNomeDisciplina;
            }

            public string getNomeDisciplina()
            {
                return nomeDisciplina;
            }

            public void setexisteDisciplina(bool VarexisteDisciplina)
            {
                this.existeDisciplina = VarexisteDisciplina;
            }

            public bool getExisteDiscipina()
            {
                return existeDisciplina;
            }

            public void setNomeCoordDisciplina(string VarNomeCoordDisciplina)
            {
                this.nomeCoordDisciplina = VarNomeCoordDisciplina;
            }

            public string getNomeCoordDisciplina()
            {
                return nomeCoordDisciplina;
            }

            public void setTempAulaDisciplina(int VarTempAulaDisciplina)
            {
                this.tempAulaDisciplina = VarTempAulaDisciplina;
            }

            public int getTempAulaDisciplina()
            {
                return tempAulaDisciplina;
            }

            public void setAulaTodoDiaDisciplina(bool VarAulaTodoDiaDisciplina)
            {
                this.aulaTodoDiaDisciplina = VarAulaTodoDiaDisciplina;
            }

            public bool getAulaTodoDiaDisciplina()
            {
                return aulaTodoDiaDisciplina;
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

            public void setExisteTurma(bool VarExisteTurma)
            {
                this.existeTurma = VarExisteTurma;
            }

            public bool getExisteTurma()
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
