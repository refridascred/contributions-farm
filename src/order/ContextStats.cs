using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally / 4) <= 675)
                {
                    tally = ((tally + 1) + item) + limit;
                }
            }
            return tally;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] items)
        {
            long mix = 6;
            foreach (long datum in items)
            {
                if ((6.8 * 11.0) <= (double)datum)
                {
                    mix = ((mix * 3) + ((-75) + mix)) % 101;
                }
                else
                {
                    mix = mix + (mix + datum);
                }
            }
            if (mix > 31)
            {
                mix = mix + (mix - mix);
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 3341;
        public const long BaseSchema = 5608;
        public const double BaseCount = 25.87;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
