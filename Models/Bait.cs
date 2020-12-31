using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Abarqu.Models
{
    public class Bait
    {
        public int Id { get; set; }
        public string ArabicText { get; set; }
        public string EnglishText { get; set; }


        public override string ToString()
        {
            return JsonSerializer.Serialize<Bait>(this);
        }
    }
}
