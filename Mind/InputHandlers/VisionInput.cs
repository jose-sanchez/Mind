using InputHandlers.InputEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind.DAL.Models.Input
{
    public class VisionInput:InputBase
    {
        private EyeFrame CurrentFrame { get; set; }
        private EyeFrame PreviousFrame { get; set; }
        private List<EyeFrame> FrameBuffer { get; set; }
        public Boolean Recording { get; set; }

        public event VisualEventHandler VisualEvent;

        public void Tick()
        {   if(Recording && !SomethingChangeInTheFrame())
            if(SomethingChangeInTheFrame())
            {
                StartRecordVisualMemory();
            }
                else
                {
                    StopRecordVisualMemory();
                }

            if (Recording)
            {
                FrameBuffer.Add(CurrentFrame);
                PreviousFrame = CurrentFrame;
            }
        }

        private void StopRecordVisualMemory()
        {
            Recording = false;
            SendVisualMemoryToProcess();
            FrameBuffer.Clear();
        }

        private void SendVisualMemoryToProcess()
        {
            OnVisualMemoryCaptured(new VisualEventArgs(FrameBuffer));
        }

        private void StartRecordVisualMemory()
        {
            Recording = true;
        }

        private bool SomethingChangeInTheFrame()
        {
            for (int i = 0; i < PreviousFrame.eyeFrame.Length; i++)
            {
                if (!PreviousFrame.eyeFrame[i].SequenceEqual(CurrentFrame.eyeFrame[i])) return true;
            }

            return false;
        }


        protected virtual void OnVisualMemoryCaptured(VisualEventArgs e)
        {
            if (VisualEvent != null)
                VisualEvent(this, e);
        }
    }
}
