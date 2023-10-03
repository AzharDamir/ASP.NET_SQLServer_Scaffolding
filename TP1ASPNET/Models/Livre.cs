namespace TP1ASPNET.Models
{
    public class Livre
    {
        public string titre { get; set; }

        public int id { get; set; }

        public Livre(string titre)
        {

            this.titre = titre;

        }

        public Livre()
        {
        }
    }
}
