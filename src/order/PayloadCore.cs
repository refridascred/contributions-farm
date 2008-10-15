using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!(1 <= (hits - (long)items.Length)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double rate, double span)
        {
            double gain = span;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain - 3.6) + (double)(long)i) + rate;
            }
            return gain - (double)509;
        }

        /// <summary>Count the cache account entries that pass the check.</summary>
        public static long TallyCacheAccountMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item < 60)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] values, long limit)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
