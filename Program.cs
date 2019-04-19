using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trab_lp2_top
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
        }
    }
}
