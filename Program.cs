namespace Universidade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IniciarPrograma();




        }
        public static void IniciarPrograma()
        {
            AddFormacao();
            AddOutraFormacao();




        }

        public static void AddFormacao()
        {
            Console.WriteLine("escolha sua formação:");
            Console.WriteLine("(  1  )....EnsinoMedio");
            Console.WriteLine("(  2 )....Tecnologo");
            Console.WriteLine("(  3 )....Bacharelado");
            int escolha = int.Parse(Console.ReadLine());

            bool repeat = true;
            List<Formacao> listFormacao = new List<Formacao>();

            do
            {
                switch (escolha)
                {
                    case 1:
                        listFormacao.Add(new EnsinoMedio("EnsinoMedio", 12, "manhã"));
                        break;

                    case 2:
                        listFormacao.Add(new Tecnologo("Tecnologo", 24, true));
                        break;

                    case 3:
                        listFormacao.Add(new Bacharelado("engenharia", 48, "TCC", 4));
                        break;

                    default:
                        Console.WriteLine("digite uma opção válida!!!");
                        repeat = false;
                        break;


                }

            } while (repeat == true);
        }


        public static void AddOutraFormacao()
            {
                bool repeat = true;
                do
                {
                    Console.WriteLine("deseja add mais alguma formação?   1|SIM   2|NÃO");
                    int confirm = int.Parse(Console.ReadLine());
                    if (confirm == 1)
                    {
                        AddFormacao();
                        repeat = true;
                    }
                    else
                    {
                        repeat = false;
                    }
                } while (repeat == true);
            }



    }


}
