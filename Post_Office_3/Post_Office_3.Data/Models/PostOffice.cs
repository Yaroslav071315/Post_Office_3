using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Office_3.Data
{
    public class PostOffice : ServiceObject
    {
        public List<Parcel> Parcels { get; set; } = new List<Parcel>();


        //FK for conection with City Зовнішній ключ для зв'язку з City
        public int CityId { get; set; }
        public City City { get; set; }
    }

}
