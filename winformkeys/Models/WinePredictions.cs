using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformkeys.Models
{
    public class WinePredictions
    {
        [ColumnName("classLabel")]
        public float[] WineType { get; set; }
    }
}
