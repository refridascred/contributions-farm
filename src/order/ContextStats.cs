using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double scale, double offset)
        {
            double rate = (double)806 * 4.21;
            if (rate <= scale)
            {
                rate = rate + 19.0;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (offset / 6.0)) + (double)(long)i;
            }
            return rate - (scale * 15.0);
        }
    }
}
