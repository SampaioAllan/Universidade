namespace Universidade
{
    public class Formacao
    {
        private string Descricao { get; set; }
        private int Periodo { get; set; }
        private double Mensalidade { get; set; }
        private int Duracao { get; set; }

        public Formacao(string descricao, int periodo)
        {
            Descricao=descricao;
            Periodo=periodo;
        }

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
        public virtual void CalcMensalidade(int fator)
        {

        }
        
        public void SetDuracao(int duracao)
        {
            Duracao=duracao;
        }
        public int GetDuracao()
        {
            return Duracao;
        }      
        public virtual void DefinirDuracao()
        {
            
        }


        public double GetMedia(double provaSemestralUm, double provaSemestralDois)
        {

            double media=(provaSemestralUm+provaSemestralDois)/2;
            return media;
        }

        public double GetMedia(double provaSemestralUm, double provaSemestralDois, double trabalhoUm, double trabalhoDois)
        {

            double mediaProvas=(provaSemestralUm+provaSemestralDois)/2;
            double mediaTrabalhos=(trabalhoUm+trabalhoDois)/2;
            double media=(mediaProvas*0.6)+(mediaTrabalhos*0.4);
            return media;
        }

        public double GetMedia(double provaSemestralUm, double provaSemestralDois, double trabalhoUm, double trabalhoDois, double provaMensalUm, double provaMensalDois)
        {

            double mediaProvasSemestrais=(provaSemestralUm+provaSemestralDois)/2;
            double mediaTrabalhos=(trabalhoUm+trabalhoDois)/2;
            double mediaProvasMensais=(provaMensalUm+provaMensalDois)/2;
            double media=(mediaProvasSemestrais*0.5)+(mediaTrabalhos*0.2)+(mediaProvasMensais*0.3);
            return media;
        }
    }
}