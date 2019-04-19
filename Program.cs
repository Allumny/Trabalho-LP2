using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho-LP2
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine("Gerenciador de matrículas v1.0");
            Console.ForegroundColor = Darkcyan;
            Console.BackgroundColor = Blue;
        }

            class Aluno{

            string nomeAluno;
            bool existeAluno = false;
            int numAluno;
            string matAluno;
            int idadeAluno;

            //metodos para nome do aluno
            public void setNomeAluno(string VarNomeAluno)
            {
                this.nomeAluno = VarNomeAluno;
            }

            public string getNomeAluno()
            {
                return nomeAluno;
            }

            public void setexisteAluno(bool VarexisteAluno)//verificar se nome existe
            {
                this.existeAluno = VarexisteAluno;
            }

            public bool getexisteAluno()
            {
                return existeAluno;
            }

            //metodos para numero do aluno
            public void setNumAluno(int VarNumAluno)
            {
                this.numAluno = VarNumAluno;
            }

            public int getNumAluno()
            {
                return numAluno;
            }

            //metodos para matricula do aluno
            public void setMatAluno(string VarMatAluno)
            {
                this.matAluno = VarMatAluno;
            }

            public string getMatAluno()
            {
                return matAluno;
            }

            //metodos para idade do aluno
            public void setIdadeAluno(int VarIdadeAluno)
            {
                this.idadeAluno = VarIdadeAluno;
            }

            public int getIdadeAluno()
            {
                return idadeAluno;
            }
        }

            class Professor{

            string nomeProf;
            bool existeProf = false;
            int idadeProf;
            string mateProf;
            int quantTempAulaProf;//quantos tempos de aula por dia que o professor dar(a quantidade é igual todos o dias)

            //metodos para nome do professor
            public void setNomeProf(string VarNomeProf)
            {
                this.nomeProf = VarNomeProf;
            }

            public string getNomeProf()
            {
                return nomeProf;
            }

            public void setexisteProf(bool VarexisteProf)//verificar se nome existe
            {
                this.existeProf = VarexisteProf;
            }

            public bool getexisteProf()
            {
                return existeProf;
            }

            //metodos para materia do professor
            public void setMateProf(string VarMateProf)
            {
                this.mateProf = VarMateProf;
            }

            public string getMateProf()
            {
                return mateProf;
            }

            //metodos para quantos tempos de aula do professor
            public void setQuantTempAulaProf(int VarQuantTempAulaProf)
            {
                this.quantTempAulaProf = VarQuantTempAulaProf;
            }

            public int getQuantTempAulaProf()
            {
                return quantTempAulaProf;
            }

            //metodos para idade do professor
            public void setIdadeProf(int VarIdadeProf)
            {
                this.idadeProf = VarIdadeProf;
            }

            public int getIdadeProf()
            {
                return idadeProf;
            }
        }

            class Disciplina{

            string nomeDisc;
            bool existeDisc = false;
            string nomeCoordDisc;
            int tempAulaDisc;//tempo de aula necessaria a ser ensinado por semana
            bool aulaTodoDiaDisc;//se é obrigatorio ter aula todo dia dessa disciplina

            //metodos para nome do disciplina
            public void setNomeDisc(string VarNomeDisc)
            {
                this.nomeDisc = VarNomeDisc;
            }

            public string getNomeDisc()
            {
                return nomeDisc;
            }

            public void setexisteDisc(bool VarexisteDisc)//verificar se nome existe
            {
                this.existeDisc = VarexisteDisc;
            }

            public bool getexisteDisc()
            {
                return existeDisc;
            }

            //metodos para nome do coodernador da disciplina
            public void setNomeCoordDisc(string VarNomeCoordDisc)
            {
                this.nomeCoordDisc = VarNomeCoordDisc;
            }

            public string getNomeCoordDisc()
            {
                return nomeCoordDisc;
            }

            //metodos para quantos tempos necessaria a ser ensinado por semana 
            public void setTempAulaDisc(int VarTempAulaDisc)
            {
                this.tempAulaDisc = VarTempAulaDisc;
            }

            public int getTempAulaDisc()
            {
                return tempAulaDisc;
            }

            //metodos para se deve ter aula todo dia
            public void setAulaTodoDiaDisc(bool VarAulaTodoDiaDisc)
            {
                this.aulaTodoDiaDisc = VarAulaTodoDiaDisc;
            }

            public bool getAulaTodoDiaDisc()
            {
                return aulaTodoDiaDisc;
            }

        }

            class Turma{

            string salaTurma;
            bool existeTurma = false;
            int numTurma;
            int quantAlunTurma;
            int quantTempAulaTurma;//quantos tempos de aula por dia (a quantidade é igual todos o dias)

            //metodos para sala da turma
            public void setSalaTurma(string VarSalaTurma)
            {
                this.salaTurma = VarSalaTurma;
            }

            public string getSalaTurma()
            {
                return salaTurma;
            }

            public void setexisteTurma(bool VarexisteTurma)//verificar se nome existe
            {
                this.existeTurma = VarexisteTurma;
            }

            public bool getexisteTurma()
            {
                return existeTurma;
            }

            //metodos para numero da turma
            public void setNumTurma(int VarNumTurma)
            {
                this.numTurma = VarNumTurma;
            }

            public int getNumTurma()
            {
                return numTurma;
            }

            //metodos para quantos alunos tem na turma
            public void setQuantAlunTurma(int VarQuantAlunTurma)
            {
                this.quantAlunTurma = VarQuantAlunTurma;
            }

            public int getQuantAlunTurma()
            {
                return quantAlunTurma;
            }

            //metodos para quantos tempos de aula a turma tem por dia
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
