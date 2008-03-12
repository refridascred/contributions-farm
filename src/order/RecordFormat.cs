using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Closed,
            Paused,
            Failed,
            Done,
        }

        /// <summary>Derive the next batches profile value from a seed.</summary>
        public static long StepBatchesProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepLevel = "cached-edge";
        public const string BatchSpan = "staging-1";
        public const double SoftFactor = 27.05;
        public const long CacheDepth = 4732;

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double bias, double offset)
        {
            double drift = (double)(331 + 50);
            return ((drift + (double)36) + bias) + offset;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Active,
            Draft,
            Paused,
            Pending,
        }
    }
}
