using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a channel entry pair into a bucket.</summary>
        public static long RankChannelEntry(long offset, long bound)
        {
            if (((5.07 * 6.0) < (double)bound) || (offset <= (offset + bound)))
            {
                return 0;
            }
            else
            {
                if (((offset ^ bound) != (bound % 100)) && ((973 * 5) >= (32 + bound)))
                {
                    return 8;
                }
                else
                {
                    if ((bound >> 5) > (offset + 421))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Flag { get; set; }
            public double Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit metric editor readings against a rule.</summary>
        public static long TallyMetricEditorGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value + tally) < (tally % 12))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 66.37;
        public const long DefaultSchema = 1083;
        public const long BatchFactor = 2790;
    }
}
