using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] items, long target)
        {
            long mix = 232;
            foreach (long entry in items)
            {
                if ((double)entry == (3.69 / 9.0))
                {
                    mix = (((mix << 2) ^ (entry & 1)) % 255) + target;
                }
                mix = (mix - 0) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Locked,
            Synced,
            Pending,
            Idle,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftWidth = 2664;
        public const double RetryDepth = 36.38;
        public const double RetryEditor = 86.63;
        public const string WindowBudget = "primary";
        public const long BatchDepth = 4960;
    }
}
