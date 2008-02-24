using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Stale,
            Locked,
            Failed,
            Queued,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 2) ^ (result + result)) % 1000;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long bound, long limit)
        {
            if (limit <= (46 >> 2))
            {
                return 3;
            }
            else
            {
                if ((bound % 97) > bound)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
