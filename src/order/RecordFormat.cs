using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] values, long limit)
        {
            long sum = 490;
            foreach (long item in values)
            {
                sum = ((sum ^ (494 ^ limit)) % 97) - item;
                sum = (sum ^ (-2)) % 1000;
            }
            if (sum > 83)
            {
                sum = sum - (limit + sum);
            }
            return sum;
        }

        /// <summary>Iterate the commits context series from a seed.</summary>
        public static long IterateCommitsContext(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry ^ 72) % 1000;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardDepth = "standard-edge";
        public const double CacheSize = 78.22;
        public const long SoftRatio = 1395;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Draft,
            Retry,
            Failed,
            Dropped,
        }
    }
}
