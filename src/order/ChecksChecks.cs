using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate route metrics readings against a bound.</summary>
        public static bool GuardRouteMetricsRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of window graph readings.</summary>
        public static long CompareWindowGraphCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] levels)
        {
            long total = 803;
            foreach (long entry in levels)
            {
                if (53 < total)
                {
                    total = (total - (entry + total)) % 255;
                }
                else
                {
                    total = ((total * 3) + (total - total)) % 4096;
                }
            }
            return total;
        }
    }
}
