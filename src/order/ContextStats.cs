using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((3.82 + 3.88) < (double)seen) || (((0.07 * 7.78) != (double)entry) && ((155 & 127) > (94 - entry))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstInterval = 8918;
        public const double MinEntry = 62.37;
        public const long WindowEntry = 8010;
        public const string BurstEntry = "cached-1";
        public const double IdleEntry = 65.98;
    }
}
