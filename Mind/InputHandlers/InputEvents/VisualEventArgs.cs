using Mind.DAL.Models.Input;
using System;
using System.Collections.Generic;

namespace InputHandlers.InputEvents
{
    public class VisualEventArgs: EventArgs
    {
        private List<EyeFrame> FrameBuffer { get; set; }

        public VisualEventArgs(List<EyeFrame> frameBuffer)
        {
            this.FrameBuffer = frameBuffer;
        }
    }
}