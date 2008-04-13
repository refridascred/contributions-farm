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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] values)
        {
            long mix = 876;
            foreach (long reading in values)
            {
                mix = ((mix - (mix % 5)) % 65521) - reading;
                mix = ((mix * 4) + (9 + 71)) % 255;
            }
            if (mix > 934)
            {
                mix = (mix + (mix - mix)) % 4096;
            }
            return mix;
        }
    }
}
