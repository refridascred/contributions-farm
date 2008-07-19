using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((sample ^ offset) <= (hits - (-57))) || !(9 >= (sample - offset)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the contributi farm series from a seed.</summary>
        public static long IterateContributiFarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = ((mix + (mix * 3)) % 65521) ^ (long)i2;
                    mix = mix ^ floor;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (bound <= (bound >> 3))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((84 - seen) != (item / 2)) && (seen > (bound ^ bound)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
