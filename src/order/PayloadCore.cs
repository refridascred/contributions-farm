using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultRatio = "standard-edge";
        public const long StepBatch = 8359;
        public const string CacheBatch = "fallback-edge";
        public const long HardFactor = 8174;

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] values)
        {
            long sum = 219;
            foreach (long item in values)
            {
                sum = ((sum - (sum * 4)) % 4096) + item;
            }
            if (sum < 221)
            {
                sum = (sum + sum) % 255;
            }
            return sum % 97;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if (carry > (861 << 2))
                {
                    carry = ((carry * 5) + (carry << 3)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
