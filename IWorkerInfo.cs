using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerProvider
{
    /// <summary>
    /// </summary>
    public class IWorkerInfo
    {
        public string IPAddress { get; set; }

        public WorkerStatus Status { get; set; }
    }
}
