using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Queued,
            Retry,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] values, long target)
        {
            long mix = 420;
            foreach (long datum in values)
            {
                if ((datum & 3) > (datum - datum))
                {
                    mix = ((mix * 3) + datum) + target;
                }
            }
            return mix % 1000;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((floor ^ floor) < item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long limit, long bound)
        {
            if (54 < bound)
            {
                return 5;
            }
            else
            {
                if ((limit ^ limit) == (limit + limit))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 9979;
        public const long SoftFactor = 7563;
        public const long RetryProfile = 6137;
        public const double BaseFactor = 92.13;
        public const long LimitProfile = 1996;
    }
}
