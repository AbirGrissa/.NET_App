using System.ComponentModel.DataAnnotations.Schema;

namespace asp_app.data
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public double Rating { get; set; }
        [ForeignKey(nameof(Country))]//notation
        public int CountryId { get; set; }//CountryId clé etrangére de la classe Country
        
        public Country Country{ get; set; }//objet pour utiliser lors de la retour d'un hotel

    }
}
