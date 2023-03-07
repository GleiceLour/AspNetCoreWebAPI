namespace SmartSchool.WebAPI.Models
{
    public class Turma
    {
        public int idTurma { get; set; }
        public List<Aluno> Alunos { get; set; } 
        public List<Professor> Professores { get; set; }
    }
}