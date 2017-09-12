using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerProvider
{
    class Program
    {
        static void Main(string[] args)
        {
            var workers = GetWorkerForHostName(hostName: "testsite.azurewebsites.net", targetCount: 10).Result;

            Console.WriteLine(string.Join(",", workers.Select(w => w.IPAddress)));
        }

        static async Task<IEnumerable<IWorkerInfo>> GetWorkerForHostName(string hostName, int targetCount)
        {
            // look for site by hostname
            SiteRecord site = await GetSiteForHostName(hostName);

            // look for provider by site
            IWorkerProvider provider = await GetWorkerProvider(site);

            // get currently assigned workers
            IEnumerable<IWorkerInfo> workers = await provider.GetWorkers(site);

            // make scale decision based on current workers and target count
            ScaleDecision decision = await MakeScaleDecision(site, workers, targetCount);

            if (decision == ScaleDecision.ScaleUp)
            {
                workers = await provider.AddWorkers(site, targetCount);
            }
            else if (decision == ScaleDecision.ScaleDown)
            {
                workers = await provider.RemoveWorkers(site, targetCount);
            }
            else
            {
                // no-op
            }

            return workers;
        }

        static Task<SiteRecord> GetSiteForHostName(string hostName)
        {
            throw new NotImplementedException();
        }

        static Task<IWorkerProvider> GetWorkerProvider(SiteRecord site)
        {
            throw new NotImplementedException();
        }

        static Task<ScaleDecision> MakeScaleDecision(SiteRecord site, IEnumerable<IWorkerInfo> workers, int targetCount)
        {
            throw new NotImplementedException();
        }

        enum ScaleDecision
        {
            None = 0,
            ScaleUp,
            ScaleDown
        }
    }
}
