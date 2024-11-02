using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP1_07_CSOrientacaoAObjetos
{
    public class GerenciarAlunos
    {
        public List<Aluno> listaAlunos { get; set; } = new List<Aluno>();

        public void cadastrarAluno(Aluno aluno) {
            listaAlunos.Add(aluno);
        }

        public void exibirSituacoes() {
            var sb = new System.Text.StringBuilder();
            foreach (Aluno aluno in listaAlunos) {
            sb.AppendLine("RA: " + aluno.Ra);
            sb.AppendLine("Nome: " + aluno.Nome);
            sb.AppendLine("Média: " + aluno.calcularMedia(aluno.Notas.ToArray()));
            sb.AppendLine("Situação: " + (aluno.calcularMedia(aluno.Notas.ToArray()) >= 7 ? "Aprovado" : "Reprovado"));
            }
            Console.WriteLine(sb.ToString());
        }
    }
}