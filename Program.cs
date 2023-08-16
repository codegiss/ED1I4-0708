Curso[] cursos;
int qtdCurso=0;


do{
  Console.WriteLine("Selecione uma opção:");
  Console.WriteLine("0. Sair");
  Console.WriteLine("1. Adicionar curso");
  Console.WriteLine("2. Pesquisar curso");
  Console.WriteLine("3. Remover curso");
  Console.WriteLine("4. Adicionar disciplina no curso");
  Console.WriteLine("5. Pesquisar disciplina no curso");
  Console.WriteLine("6. Remover disciplina do curso");
  Console.WriteLine("7. Matricular aluno na disciplina");
  Console.WriteLine("8. Remover aluno da disciplina");
  Console.WriteLine("9. Pesquisar aluno");
  Console.Write("Opção escolhida: ");
  int op = int.Parse(console.ReadLine());
} while (op<0 || op>9);

switch(op){
  case 1:
    if(qtdCurso<5){
      Console.Write("Qual o nome do curso? ");
      string nomeCurso = Console.ReadLine();
      cursos[qtdCurso] = new Curso(qtdCurso, nomeCurso);
      qtdCurso++;
    }
    else{
      Console.WriteLine("A escola já possui cinco cursos.");
    }
    break;
  case 2:
    break;
  case 3:
    break;
  case 4:
    break;
  case 5:
    break;
  case 6:
    break;
  case 7:
    break;
  case 8:
    break;
  case 9:
    break;
}