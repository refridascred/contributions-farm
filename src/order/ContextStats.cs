using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Weight { get; set; }
            public double Mode { get; set; }
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
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
