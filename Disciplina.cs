class Disciplina
{
    int id {get;set;}
    string descricao {get;set;}
    Aluno[] alunos = new Aluno[15] {get;set;}
    
    bool matricularAluno(Aluno aluno){
        return false;
    }
    
    bool desmatricularAluno(Aluno aluno){
        return false;
    }
}