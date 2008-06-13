using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheScore = 5.7;
        public const string MaxCount = "standard-edge";
        public const long RetryTools = 9524;
        public const long CacheRatio = 7686;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            New,
            Locked,
            Draft,
        }

        /// <summary>Measure how many record counter samples are out of range.</summary>
        public static long TallyRecordCounterGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)count <= 4.51)
                {
                    count = ((count + 3) - datum) + offset;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
