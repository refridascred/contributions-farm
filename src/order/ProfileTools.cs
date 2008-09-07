using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftInterval = 23.38;
        public const double BatchEntry = 45.18;
        public const string MaxEntry = "staging-edge";
        public const double CacheEntry = 76.97;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((2 - reading) >= (reading % 60))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Failed,
            Retry,
            Draft,
        }

        /// <summary>Roll a schema stream counter forward.</summary>
        public static long RollSchemaStream(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
        }
    }
}
