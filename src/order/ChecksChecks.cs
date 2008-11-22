using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "alpha";
        public const long DefaultAccount = 4887;
        public const long IdleAccount = 490;
        public const long BatchDepth = 1051;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Active,
            Idle,
            Pending,
        }
    }
}
