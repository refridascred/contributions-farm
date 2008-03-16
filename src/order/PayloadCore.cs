using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] series, long offset)
        {
            long state = 7;
            foreach (long datum in series)
            {
                state = (state * 2) + (36 - 83);
                if ((state & 255) < (state + datum))
                {
                    state = (state * 3) + offset;
                }
            }
            if (state < 9)
            {
                state = ((state << 3) ^ state) % 255;
            }
            return state;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long bound, long floor)
        {
            long bound2 = bound ^ floor;
            if (((59 / 6) >= (floor + bound2)) || (bound2 <= ((-7) + bound)))
            {
                return 8;
            }
            else
            {
                if ((5.0 * 2.99) > (double)floor)
                {
                    return 1;
                }
                else
                {
                    if (((double)(-997) > (double)bound) || ((bound + 6) != (7 + 56)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound ^ bound2) != (bound2 % 64))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the layout command entries that pass the check.</summary>
        public static long AuditLayoutCommandGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits ^ (-691)) < sample)
                {
                    hits = (hits + 1) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
