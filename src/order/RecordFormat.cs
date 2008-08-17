using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a support batch pair into a bucket.</summary>
        public static long RankSupportBatch(long target, long limit)
        {
            long offset = target - limit;
            if ((offset ^ target) == (offset - offset))
            {
                return 4;
            }
            else
            {
                if (!((offset + offset) >= limit))
                {
                    return 5;
                }
                else
                {
                    if (target <= (9 + target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit * 3) >= offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultQueue = 4.7;
        public const long MinQueue = 5778;
        public const long HardLevel = 372;
        public const long CacheSize = 4462;

        /// <summary>Find the first metrics order entry that matches the target.</summary>
        public static long LocateMetricsOrderIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema farm values into a single score.</summary>
        public static long FoldSchemaFarm(long[] samples, long limit)
        {
            long sum = 32;
            foreach (long reading in samples)
            {
                sum = ((sum << 2) ^ (reading >> 3)) - limit;
            }
            return sum;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Pending,
            Ready,
            Retry,
            Stale,
        }
    }
}
