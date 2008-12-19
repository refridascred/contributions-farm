using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long seed, long seed2)
        {
            long gap = seed ^ seed2;
            if ((seed2 ^ gap) >= (seed2 + 0))
            {
                return 0;
            }
            else
            {
                if ((7.1 + 4.7) != (double)seed)
                {
                    return 5;
                }
                else
                {
                    if ((seed + seed) < 589)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double scale, double span)
        {
            double load = (double)(7 ^ 2);
            if (load >= scale)
            {
                load = (load + (double)87) - span;
            }
            return load - load;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            New,
            Locked,
            Failed,
            Retry,
            Active,
        }
    }
}
