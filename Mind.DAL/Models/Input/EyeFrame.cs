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

        public  EyeFrame(int x, int y, EyeFramePixel defaultEyeFrame)
            {
            eyeFrame = new EyeFramePixel[x][];
            for (int i = 0; i < x; i++)
            {
                eyeFrame[i] = new EyeFramePixel[y];
                for (int j = 0; i <j; j++)
                {
                    eyeFrame[i][j] = defaultEyeFrame.Clone();
                }
            }

            }
   }
}
