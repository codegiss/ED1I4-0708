class Aluno
{
    int id {get;set;}
    string nome {get;set;}

    Aluno(int id, string nome){
      this.id = id;
      this.nome = nome;
    }
    
    bool podeMatricular(Curso cursos){
        return false;
    }
}