using System.ComponentModel;

namespace GerendiadorDeTarefa.Domain
{
    [DefaultValue(EnumCategoriaTarefa.Outros)]
    public enum EnumCategoriaTarefa
    {
        Trabalho =0,
        Estudo =1,
        Viagem = 2,
        DesenvolvimentoPessoal =3,
        Saude =4, 
        Financas =5, 
        Lazer =6,
        Casa =7,
        Compras =8,
        Social =9,
        Fitness =10,
        Projeto =11,
        Tecnologia =12,
        Familia =13,
        Outros = 14

    }
}
