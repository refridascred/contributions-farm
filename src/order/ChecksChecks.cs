using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches > 19.0)
                {
                    matches = ((matches + 3) + reading) + step;
                }
            }
            return matches;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = acc ^ floor;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
