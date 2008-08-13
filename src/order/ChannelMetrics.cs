using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((double)35 == (double)seen) || ((double)6 == (double)seen))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 2276;
        public const long MaxBuffer = 5686;
        public const double LimitSpan = 83.52;
        public const double StepDepth = 13.03;

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long offset, long offset2)
        {
            long delta = offset ^ offset2;
            if (offset2 > (53 / 7))
            {
                return 1;
            }
            else
            {
                if (((offset2 * 4) != (delta + offset2)) && (3.77 < (double)delta))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
