using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Dropped,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] data)
        {
            long result = 223;
            foreach (long sample in data)
            {
                if ((sample % 60) > (sample + 50))
                {
                    result = (result << 2) ^ ((-309) ^ result);
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Queued,
            New,
            Dropped,
            Failed,
        }
    }
}
