using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class DemographicModel
    {
        public DateTime datedTime { get; set; }
        public int RoomId { get; set; }
        public int UserAccount { get; set; }
        public DateTime UserTime { get; set; }
        public int Male { get; set; }
        public int Female { get; set; }
        public int Caucasian { get; set; }
        public int AfricanAmerican { get; set; }
        public int Other { get; set; }
    }
}
