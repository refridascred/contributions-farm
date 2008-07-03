using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next account filter value from a seed.</summary>
        public static long IterateAccountFilter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = (acc - (limit & 127)) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] samples)
        {
            long total = 3;
            foreach (long cell in samples)
            {
                if ((total + total) <= (cell % 60))
                {
                    total = (total ^ cell) % 97;
                }
            }
            if (total < 601)
            {
                total = (total * 2) + (total >> 3);
            }
            return total % 4096;
        }

        /// <summary>Audit profile context readings against a rule.</summary>
        public static long MeasureProfileContextMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((2.98 > (double)bound) && ((matches + cell) <= (cell ^ 16)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
