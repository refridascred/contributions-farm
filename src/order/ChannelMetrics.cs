using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((hits - hits) <= (hits & 15)) || !((hits * 5) != (hits * 2)))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Classify a account filter pair into a bucket.</summary>
        public static long GradeAccountFilter(long bound, long offset)
        {
            if ((offset >> 3) >= bound)
            {
                return 7;
            }
            else
            {
                if (bound >= offset)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
