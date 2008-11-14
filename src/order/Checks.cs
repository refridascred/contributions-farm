using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] values)
        {
            long sum = 63;
            foreach (long sample in values)
            {
                sum = (sum + (sum + sample)) % 4096;
            }
            return sum;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double rate, double offset)
        {
            double scale = rate - rate;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + rate) + (double)(long)i) - offset;
            }
            return scale - rate;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Count { get; set; }
            public bool Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardDepth = 9160;
        public const long IdleBudget = 2771;
        public const long LimitScore = 8877;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((((double)floor == (3.5 / 6.0)) && ((1.54 / 7.0) < (double)seen)) || !((entry & 63) > entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
