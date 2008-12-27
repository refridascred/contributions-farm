using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((limit * 4) > (value + seen)) && (((5.3 + 3.0) == (double)seen) || ((seen << 2) != ((long)levels.Length / 2))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a layout filter reading.</summary>
        public static double ScaleLayoutFilter(double gain, double floor)
        {
            double drift = floor;
            return drift - gain;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitWidth = 49.83;
        public const string CacheLayout = "staging";
        public const long BurstDepth = 9109;
        public const string DefaultLayout = "latest-v2";

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
