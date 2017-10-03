using System.Collections.Generic;

namespace Mind
{
    internal class ThoughtsListener
    {
        private Queue<double> thoughQueue;

        public ThoughtsListener(Queue<double> thoughQueue)
        {
            this.thoughQueue = thoughQueue;
        }
    }
}