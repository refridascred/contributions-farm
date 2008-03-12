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

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
