namespace Universidade
{
    public class EnsinoMedio : Formacao
    {
        public string Tipo { get; set; }
        public EnsinoMedio(string descricao, int periodo, string tipo) : base(descricao, periodo)
        {
            Tipo=tipo;
        }

        public override void DefinirDuracao()
        {           
            SetDuracao(36);   

        }
        public override void CalcMensalidade(int fator)
        {
            int mensalidade= (GetDuracao()*fator*8)+(CargaHorariaEstagio*12);
        }
    }
}