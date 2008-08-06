using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Region { get; set; }
            public double Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits <= datum)
                {
                    hits = (hits + 3) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public double Total { get; set; }
        }
    }
}
