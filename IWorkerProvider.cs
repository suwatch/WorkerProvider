using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerProvider
{
    public interface IWorkerProvider
    {
        Task<IEnumerable<IWorkerInfo>> GetWorkers(SiteRecord site);

        // return effective workers
        Task<IEnumerable<IWorkerInfo>> AddWorkers(SiteRecord site, int targetCount);

        // return effective workers
        Task<IEnumerable<IWorkerInfo>> RemoveWorkers(SiteRecord site, int targetCount);

        // return effective workers
        Task<IEnumerable<IWorkerInfo>> RemoveWorkers(SiteRecord site, IEnumerable<IWorkerInfo> workers);
    }
}
