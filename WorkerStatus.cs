using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerProvider
{
    [Flags]
    public enum WorkerStatus
    {
        /// <summary>
        /// worker is not ready
        /// </summary>
        NotReady = 0x0000,

        /// <summary>
        /// worker is ready for loadbalancing (ready for use)
        /// </summary>
        ReadyForLoadBalancing = 0x0001,

        /// <summary>
        /// worker is assigned to a site
        /// </summary>
        Assigned = 0x0002,

        /// <summary>
        /// worker is assigned and warmup
        /// </summary>
        ReadyForRequest = 0x0004 | Assigned,

        /// <summary>
        /// worker is assigned and draining (stopping)
        /// </summary>
        Draining = 0x0008 | Assigned,
    }
}
