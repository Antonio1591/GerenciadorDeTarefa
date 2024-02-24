
using GerendiadorDeTarefa.Domain;

namespace GerendiadorDeTarefa.Domain
{
    public class Tarefa : Entidade
    {
        protected Tarefa() { }
        public Tarefa(Pessoa resposaveltarefa, string tarefadescriscao, DateTime datainicio, DateTime dataconclusaoesperada, EnumCategoriaTarefa enumCategoriaTarefa = default,
            string categoriaTarefaDescricao = "", EnumPrioridadeTarefa enumPrioridadeEnum = default,
            string prioridadeDescriscao = "", EnumStatusTarefa status = default, bool tarefaconcluida = false)
        {

            var validarParametros = ValidarParametros(resposaveltarefa, tarefadescriscao, datainicio, dataconclusaoesperada, enumCategoriaTarefa, enumPrioridadeEnum);

            if (!validarParametros)
                return;

            ResponsavelTarefa = resposaveltarefa;
            TarefaDescriscao = tarefadescriscao;
            DataInicio = datainicio;
            DataConclusaoEsperada = dataconclusaoesperada;
            EnumCategoriaTarefa = enumCategoriaTarefa;
            CategoriaTarefaDescricao = categoriaTarefaDescricao;
            EnumPrioridadeEnum = enumPrioridadeEnum;
            PrioridadeDescriscao = prioridadeDescriscao;
            Status = status;
            TarefaConcluida = tarefaconcluida;

        }



        public int TarefaId { get;  set; }
        public Pessoa ResponsavelTarefa { get; private set; }
        public string TarefaDescriscao { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataConclusaoEsperada { get; private set; }
        public DateTime DataConclusao { get; private set; }
        public EnumCategoriaTarefa EnumCategoriaTarefa { get; private set; }
        public string CategoriaTarefaDescricao { get; private set; }
        public EnumPrioridadeTarefa EnumPrioridadeEnum { get; private set; }
        public string PrioridadeDescriscao { get; private set; }
        public EnumStatusTarefa Status { get; private set; }
        public bool TarefaConcluida { get; private set; }


        //public void CadastrarTarefa(Pessoa resposaveltarefa, string tarefadescriscao, DateTime datainicio, DateTime dataconclusaoesperada, EnumCategoriaTarefa enumCategoriaTarefa = default, string categoriaTarefaDescricao = "",
        //        EnumPrioridadeTarefa enumPrioridadeEnum = default, string prioridadeDescriscao = "", EnumStatusTarefa status = default, bool tarefaconcluida = false)
        //{

        //    var validarParametros = ValidarParametros(resposaveltarefa, tarefadescriscao, datainicio, dataconclusaoesperada, enumCategoriaTarefa, enumPrioridadeEnum);

        //    if (!validarParametros)
        //        return;

        //    ResponsavelTarefa = resposaveltarefa;
        //    TarefaDescriscao = tarefadescriscao;
        //    DataInicio = datainicio;
        //    DataConclusaoEsperada = dataconclusaoesperada;
        //    EnumCategoriaTarefa = enumCategoriaTarefa;
        //    CategoriaTarefaDescricao = categoriaTarefaDescricao;
        //    EnumPrioridadeEnum = enumPrioridadeEnum;
        //    PrioridadeDescriscao = prioridadeDescriscao;
        //    Status = status;
        //    TarefaConcluida = tarefaconcluida;

        //}


        public void ConcluirTarefa(Pessoa resposaveltarefa, string tarefadescriscao, DateTime datainicio, DateTime dataconclusaoesperada, DateTime dataconclusao, EnumCategoriaTarefa enumCategoriaTarefa, string categoriaTarefaDescricao,
                                   EnumPrioridadeTarefa enumPrioridadeEnum, string prioridadeDescriscao, EnumStatusTarefa status, bool tarefaconcluida)
        {
            var validarParametros = ValidarParametros(resposaveltarefa, tarefadescriscao, datainicio, dataconclusaoesperada, enumCategoriaTarefa, enumPrioridadeEnum);

            if (!validarParametros)
                return;

            if (DataConclusao != null && DataConclusao < DataInicio)
                AddErro("Data de conclusão não pode ser anterior à data de início.");

            if (status != EnumStatusTarefa.Concluida)
                AddErro("A tarefa não pode ser concluída porque não está com status de conclusão.");

            if (!EhValido)
                return;

            DataConclusao = dataconclusao;
            Status = status;
            TarefaConcluida = true;

        }


        private bool ValidarParametros(Pessoa resposaveltarefa, string tarefadescriscao, DateTime datainicio, DateTime dataconclusaoesperada, EnumCategoriaTarefa enumCategoriaTarefa = default, EnumPrioridadeTarefa enumPrioridadeEnum = default)
        {
            if (resposaveltarefa == null)
                AddErro("Responsável pela tarefa não pode ser nulo.");

            if (string.IsNullOrEmpty(tarefadescriscao))
                AddErro("Descrição da tarefa não pode ser vazia.");

            if (datainicio < DateTime.Now.AddMonths(-12))
                AddErro("Data de início não pode ter um inicio de 1 ano atrás");

            if (datainicio > dataconclusaoesperada)
                AddErro("Data de início não pode ser posterior à data de conclusão esperada.");

            if (!Enum.IsDefined(typeof(EnumCategoriaTarefa), enumCategoriaTarefa))
                AddErro("Categoria da tarefa não pode ser nula.");

            if (!Enum.IsDefined(typeof(EnumPrioridadeTarefa), enumPrioridadeEnum))
                AddErro("Prioridade da tarefa inválida.");

            return EhValido ? true : false;
        }


    }
}