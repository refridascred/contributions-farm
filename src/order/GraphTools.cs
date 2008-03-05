using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BurstTimeout = 4062;
        public const long BurstBudget = 9218;
        public const long CacheReport = 8589;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Draft,
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] samples, long offset)
        {
            long carry = 322;
            foreach (long datum in samples)
            {
                carry = (((carry * 3) + (1 >> 2)) - datum) - offset;
            }
            if (carry > 2)
            {
                carry = (carry ^ carry) % 97;
            }
            return carry;
        }
    }
}
