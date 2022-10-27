using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WvcCore2.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        internal List<Province> FetchAll()
        {
            throw new NotImplementedException();
        }

        internal Province FetchOne(int id)
        {
            throw new NotImplementedException();
        }

        internal static string AddProvince(Province province)
        {
            throw new NotImplementedException();
        }
    }
}
