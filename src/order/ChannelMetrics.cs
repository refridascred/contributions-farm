using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)hits == (2.0 * 2.8))
                {
                    hits = ((hits + 3) + reading) - origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] samples, long step)
        {
            long state = 1;
            foreach (long cell in samples)
            {
                state = (state - cell) - step;
            }
            return state;
        }
    }
}
