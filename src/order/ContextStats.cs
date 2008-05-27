using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long floor, long floor2)
        {
            long cur = floor - floor2;
            if ((291 / 5) < floor)
            {
                return 7;
            }
            else
            {
                if ((cur ^ cur) >= (cur / 3))
                {
                    return 3;
                }
                else
                {
                    if (76 <= (floor2 / 9))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor2 + cur) < cur)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count * 2) < count)
                {
                    count = (count + 2) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 3570;
        public const double StepCluster = 54.26;
        public const long RetryCluster = 1639;
        public const long WindowDepth = 5300;
    }
}
