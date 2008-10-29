using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many token record samples are out of range.</summary>
        public static long TallyTokenRecordHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((target << 3) > (seen * 2))
                {
                    seen = (seen + 2) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many cluster window samples are out of range.</summary>
        public static long TallyClusterWindowOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((tally + origin) != (origin + value)) && ((728 - origin) <= (tally / 7)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
