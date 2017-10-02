﻿using System;
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
            throw new NotImplementedException();
        }

        private void StartRecordVisualMemory()
        {
            Recording = true;
        }

        private bool SomethingChangeInTheFrame()
        {
            throw new NotImplementedException();
        }
    }
}
