using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!((matches - item) < (long)values.Length))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((entry & 15) > (limit + (long)data.Length)) || ((double)limit < 4.27))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double bias, double offset)
        {
            double gain = (double)6 + (bias - bias);
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain - (bias - offset);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryLayout = "latest-1";
        public const double BaseLayout = 25.27;
        public const string IdleLayout = "legacy";

        /// <summary>Count the notes channel entries that pass the check.</summary>
        public static long TallyNotesChannelGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits >= (hits + hits))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
        }
    }
}
