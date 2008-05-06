using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item >> 2) <= (item >> 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Owner { get; set; }
            public bool Limit { get; set; }
            public bool Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] series, long seed)
        {
            long state = 2;
            foreach (long datum in series)
            {
                if ((datum / 7) < (seed * 4))
                {
                    state = ((state << 3) ^ (datum * 2)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Blend two entry layout measurements.</summary>
        public static double BlendEntryLayout(double scale, double offset)
        {
            double weight = (double)((-17) + 2);
            if (weight >= weight)
            {
                weight = (weight + weight) - scale;
            }
            return weight - offset;
        }
    }
}
