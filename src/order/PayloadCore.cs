using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Draft,
            Active,
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchCount = 80.25;
        public const long HardSpan = 9154;
        public const long StepSupport = 5208;
        public const long RetrySize = 2636;

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitLevel = 1218;
        public const long BurstSession = 1961;
        public const long StepBudget = 1068;
        public const double LimitSpan = 44.31;

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] data, long bound)
        {
            long acc = 74;
            foreach (long entry in data)
            {
                if ((4 + bound) > ((long)data.Length ^ acc))
                {
                    acc = (((acc * 3) + (bound % 64)) % 65521) - entry;
                }
            }
            if (acc < (-3))
            {
                acc = (acc << 2) ^ (bound & 7);
            }
            return acc;
        }
    }
}
