namespace Universidade
{
    public class Formacao
    {
        private string Descricao { get; set; }
        private int Periodo { get; set; }
        private double Mensalidade { get; set; }
        private int Duracao { get; set; }

        public void SetDescricao(string descricao)
        {
            Descricao=descricao;
        }

        public string GetDescricao()
        {
            return Descricao;
        }

        public void SetPeriodo(int periodo)
        {
            Periodo=periodo;
        }

        public int Getperiodo()
        {
            return Periodo;
        }

        public void SetMensalidade(double mensalidade)
        {
            Mensalidade=mensalidade;
        }

        public double GetMensalidade()
        {
            return Mensalidade;
        }
        
        public void SetDuracao(int duracao)
        {
            Duracao=duracao;
        }
        public int GetDuracao()
        {
            return Duracao;
        }        
    }
}