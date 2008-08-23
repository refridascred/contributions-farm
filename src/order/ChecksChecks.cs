using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate farm queue readings against a bound.</summary>
        public static bool CheckFarmQueueBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Validate queue metric readings against a bound.</summary>
        public static bool ValidateQueueMetricBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
