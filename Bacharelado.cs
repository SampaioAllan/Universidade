namespace Universidade
{
    public class Bacharelado : Formacao
    {
        public string Descricao { get; set; }
        public string ProjetoConclusao { get; set; }
        public int CargaHorariaEstagio { get; set; }
        public Bacharelado(string descricao, int periodo, string projetoConclusao, int cargaHorariaEstagio) : base(descricao, periodo)
        {
            Descricao = descricao;
            ProjetoConclusao = projetoConclusao;
            CargaHorariaEstagio = cargaHorariaEstagio;
        }
        public override void DefinirDuracao()
        {
            bool adicional = Descricao.Contains("engenharia");

            if (adicional == false)
            {
                SetDuracao(48);
            }
            else
            {
                SetDuracao(60);
            }

        }
        public override void CalcMensalidade(int fator)
        {
            int mensalidade= (GetDuracao()*fator*8)+(CargaHorariaEstagio*12);
        }
    }
}