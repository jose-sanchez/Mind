using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.DAL.Models.Memory
{
    public class LexicalVisualAssociativeMemory
    {
        string Word { get; set; }
        double Id { get; set; }
        List<double> AssociatedWordsIds { get; set; }
        List<double> ImageMemoryIds{ get; set; }
}
}
