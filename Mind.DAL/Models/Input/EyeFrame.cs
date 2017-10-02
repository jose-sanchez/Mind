using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.DAL.Models.Input
{
    public class EyeFrame
    {
        public EyeFramePixel[][] eyeFrame;

        public  EyeFrame(int x, int y)
            {
            eyeFrame = new EyeFramePixel[x][y];
            }
   }
}
