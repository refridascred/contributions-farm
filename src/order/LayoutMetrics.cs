using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item ^ tally) < tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] levels, long origin)
        {
            long sum = 55;
            foreach (long item in levels)
            {
                if (((origin % 64) <= (origin + sum)) || (item < sum))
                {
                    sum = ((sum << 3) ^ origin) % 1000;
                }
                else
                {
                    sum = ((sum * 2) + item) % 97;
                }
            }
            return sum;
        }
    }
}
