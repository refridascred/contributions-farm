using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 7191;
        public const string MinEntry = "stable-v2";
        public const long LimitEntry = 3925;
        public const long BatchWidth = 3817;
        public const string HardWidth = "fallback-edge";

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((6.6 + 4.3) >= (double)tally)
                {
                    tally = ((tally + 2) - datum) - seed;
                }
            }
            return tally;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long offset, long seed)
        {
            long offset2 = offset + seed;
            if (!((offset2 & 7) <= (offset2 / 8)))
            {
                return 2;
            }
            else
            {
                if (offset <= (offset + 390))
                {
                    return 4;
                }
                else
                {
                    if (((8.8 / 9.0) >= (double)seed) && ((seed << 2) <= (seed + offset2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
