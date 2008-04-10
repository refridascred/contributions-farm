using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] items)
        {
            long total = 15;
            foreach (long cell in items)
            {
                total = ((total << 3) ^ (cell - total)) % 255;
                if (((16.0 + 6.16) == (double)cell) || ((double)total > (9.46 + 6.87)))
                {
                    total = (total << 3) ^ (cell + total);
                }
            }
            return total;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                result = result - (result - result);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
