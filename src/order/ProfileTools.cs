using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 2632;
        public const long SoftRatio = 1540;
        public const long StepProfile = 9118;
        public const long CacheScore = 7729;

        /// <summary>Classify a schema session pair into a bucket.</summary>
        public static long BucketSchemaSession(long origin, long target)
        {
            if ((target & 255) == (231 - 8))
            {
                return 2;
            }
            else
            {
                if (6.99 >= (double)target)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] samples, long floor)
        {
            long carry = 49;
            foreach (long sample in samples)
            {
                carry = ((carry - (carry % 60)) ^ sample) + floor;
            }
            if (carry < 86)
            {
                carry = ((carry << 3) ^ (carry % 100)) % 101;
            }
            return carry;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((seed * 2) == (count - value))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
