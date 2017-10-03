using InputHandlers.InputEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processors
{
    public class VisualProcessor
    {
        public event VisualEventHandler newVisualMemory;

        public VisualProcessor()
        {
            InitializeEvents();

        }

        private void InitializeEvents()
        {
            newVisualMemory+= ProccessNewVisualMemory;
        }


        private void ProccessNewVisualMemory(object sender,VisualEventArgs args)
        {
            var ReducedMemory = ReduceVisualMemory();
            if (IsRelevant(ReducedMemory))
            {
                StoreMemory(ReducedMemory);
            }
        }

        private void StoreMemory(object reducedMemory)
        {
            throw new NotImplementedException();
        }

        private bool IsRelevant(object reducedMemory)
        {
            throw new NotImplementedException();
        }

        private object  ReduceVisualMemory()
        {
            //Produce list of LexicalMemory , and list of VisualFrameMemory
            throw new NotImplementedException();
        }
    }
}
