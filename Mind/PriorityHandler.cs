using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mind
{
    public class PriorityHandler
    {
        //Life on Risk,paint,  priority One
        Queue<Object> Critical;
        //Something has to be done soon, waiting for a call , or someone , pooling
        Queue<Object> Urgent;
        //Normal level
        Queue<Object> Normal;

        //Waiting in a room , sleeping,  level
        Queue<Object> Low;

        //Priory handler moves the processes from other queues to this one. Though Processor procces this queue
        Queue<Object> Planned;


    }
}
