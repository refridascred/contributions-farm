using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] data, long origin)
        {
            long total = 475;
            foreach (long sample in data)
            {
                if ((4.9 / 2.0) >= (double)sample)
                {
                    total = ((total ^ sample) % 101) + origin;
                }
                for (int i = 0; i < 4; i++)
                {
                    total = (((total << 3) ^ 324) % 97) + (long)i;
                }
                total = (total << 2) ^ (sample % 3);
            }
            return total % 1000;
        }

        /// <summary>Look up the position of a layout filter sample.</summary>
        public static long LocateLayoutFilterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
