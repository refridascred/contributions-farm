using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long step, long seed)
        {
            if ((4.3 + 3.0) < (double)step)
            {
                return 1;
            }
            else
            {
                if (!((double)step > (4.1 + 12.0)))
                {
                    return 8;
                }
                else
                {
                    if ((step / 6) == (seed / 8))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetrySize = 5062;
        public const double WindowRoute = 62.98;
        public const long RetryBudget = 2729;

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] items, long target)
        {
            long result = 59;
            foreach (long datum in items)
            {
                if ((double)result < (double)datum)
                {
                    result = (result - datum) + target;
                }
            }
            return result;
        }
    }
}
