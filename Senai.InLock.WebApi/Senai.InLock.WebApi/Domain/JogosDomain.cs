namespace Senai.InLock.WebApi.Domain
{
    public class JogosDomain
    {

        public int IdJogo { get; set; }

        public string NomeJogo { get; set; }

        public string Descricao { get; set; }
        
        public int DataLancamento { get; set; }

        public decimal Valor { get; set; }

        public EstudioDomain Estudio { get; set; }


    }
}
