class Curso{
    int id;
    string descricao;
    Disciplina[] disciplina = new Disciplina[12];

    Curso(int id, string descricao){
      this.id = id;
      this.descricao = descricao;
    }
    
    bool adicionarDisciplina(Disciplina disciplina){
        return false;
    }
    
    Disciplina pesquisarDisciplina(Disciplina disciplina){
        return disciplina;
    }
    
    bool removerDisciplina(Disciplina disciplina){
        return false;
    }
}