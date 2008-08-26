using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Ready,
            Dropped,
            Closed,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double ratio, double span)
        {
            double ratio2 = 8.5;
            return ((ratio2 - (double)20) + ratio) + span;
        }

        /// <summary>Count order farm pairs that satisfy a relation.</summary>
        public static long OverlapOrderFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
