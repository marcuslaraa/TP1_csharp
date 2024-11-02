using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP1_07_CSOrientacaoAObjetos
{
  public class Aluno
  {
    public string Ra { get; private set; }
    public string Nome { get; private set; }
    public List<float> Notas { get; private set; } = new List<float>(4);

    public Aluno(string ra, string nome, List<float> notas) {
      Ra = ra;
      Nome = nome;
      Notas = notas;
    }

    public float calcularMedia(float[] notas) {
      float media = 0;
      for(int i = 0; i < 4; i++) {
          if(i <= 2)
              media += notas[i] * 0.1f;
          media += notas[i] * 0.7f;
      }
      return media;
    } 

  }

}