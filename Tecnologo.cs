namespace Universidade
{
    public class Tecnologo : Formacao
    {
        public bool PlanoEstendido { get; set; }
        public Tecnologo(string descricao, int periodo, bool planoEstendido) : base(descricao, periodo)
        {
            PlanoEstendido=planoEstendido;
        }
        public override void DefinirDuracao()
        {           
            SetDuracao(24);   

        }
        public override void CalcMensalidade(int fator)
        {
            int mensalidade= (GetDuracao()*fator*8)+(CargaHorariaEstagio*12);
        }
    }
}