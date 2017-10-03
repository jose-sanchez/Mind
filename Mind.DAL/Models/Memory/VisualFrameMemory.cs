using Mind.DAL.Models.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.DAL.Models.Memory
{
    public class VisualFrameMemory
    {
        string HumanLanguageTerm { get; set; }
        Double Id { get; set; }
        EyeFrame ObjetImage { get; set; }
        List<int> AssociatedMemory { get; set; }

}
}
