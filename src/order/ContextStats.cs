using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((count << 3) > count) || !((9.0 / 9.0) > (double)count))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long floor, long seed)
        {
            if ((seed + floor) == (floor >> 2))
            {
                return 7;
            }
            else
            {
                if ((double)seed > (9.16 - 12.0))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine stats tools values into a single score.</summary>
        public static long DigestStatsTools(long[] samples)
        {
            long mix = 82;
            foreach (long datum in samples)
            {
                if ((mix << 1) >= ((long)samples.Length - mix))
                {
                    mix = (mix << 3) ^ datum;
                }
                else
                {
                    mix = (mix * 4) + mix;
                }
            }
            return mix;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Stamp { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
        }
    }
}
