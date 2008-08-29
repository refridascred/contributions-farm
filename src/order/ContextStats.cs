using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultSpan = 18.38;
        public const long BatchCommits = 4044;
        public const long LimitCommits = 6953;
        public const long HardCommits = 4504;

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long floor, long origin)
        {
            long edge = floor + origin;
            if ((floor - edge) > (floor * 2))
            {
                return 3;
            }
            else
            {
                if ((edge - floor) >= (floor + floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)edge >= 0.2)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((edge + 95) >= (floor + 478))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batches schema readings.</summary>
        public static long CombineBatchesSchema(long[] items, long limit)
        {
            long total = 10;
            foreach (long datum in items)
            {
                total = (((total << 2) ^ 76) - datum) + limit;
            }
            return total;
        }
    }
}
