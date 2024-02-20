namespace GerenciadorDeTarefa.Domain.InputModel
{
    public class PessoaInputModel
    {
            public int IdPessoa { get;  set; }
            public string PessoaNome { get;  set; }
            public string PessoaSex { get;  set; }
            public string CPF { get;  set; }
            public DateOnly DataNascimento { get;  set; }
            public string Telefone { get;  set; }
        
    }
}
