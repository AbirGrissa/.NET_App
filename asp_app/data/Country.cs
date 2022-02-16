using System.Collections.Generic;

namespace asp_app.data
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public virtual ICollection<Hotel> Hotels { get; set; }//liste des hotels

    }
}
