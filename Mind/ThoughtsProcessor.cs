using System.Collections.Generic;

namespace Mind
{
    internal class ThoughtsProcessor
    {
        private Queue<double> thoughQueue;

        public ThoughtsProcessor(Queue<double> thoughQueue)
        {
            this.thoughQueue = thoughQueue;
        }
    }
}