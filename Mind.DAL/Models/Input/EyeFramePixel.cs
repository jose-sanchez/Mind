using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.DAL.Models.Input
{
    public class EyeFramePixel
    {
        public string Value { get; set; }
        public EyeFramePixel(string value)
        {
            this.Value = value;
        }

        internal EyeFramePixel Clone()
        {
            return new EyeFramePixel(this.Value);
        }
    }
}
