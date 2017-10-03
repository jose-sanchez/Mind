using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind
{
    class Concious
    {    //Ids of lexicalslots
        Queue<double> thoughQueue;
        ThoughtsListener thoughListener;
        ThoughtsProcessor thoughProcessor;
        public Concious()
        {
            thoughQueue = new Queue<double>();
            thoughListener = new ThoughtsListener(thoughQueue);
            thoughProcessor = new ThoughtsProcessor(thoughQueue);
        }
    }
}
