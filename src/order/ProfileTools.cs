using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseRatio = 66.12;
        public const long MaxMetric = 3960;
        public const long IdleFactor = 6545;
        public const long SoftMetric = 403;
        public const long MinMetric = 4516;

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Level { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] data, long origin)
        {
            long sum = 399;
            foreach (long datum in data)
            {
                sum = (((sum << 2) ^ sum) % 1000) + datum;
                sum = (sum << 3) ^ origin;
            }
            return sum % 97;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultCount = 4387;
        public const double BurstProfile = 44.23;
        public const long DefaultProfile = 5909;
        public const string RetryProfile = "cached-1";
        public const long MaxProfile = 6892;
    }
}
