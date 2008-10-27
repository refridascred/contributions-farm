using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Idle,
            Ready,
            Active,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 2815;
        public const double IdleSize = 53.31;
        public const string CacheEditor = "fallback-v2";
        public const string MaxBudget = "open-edge";
        public const long SoftInterval = 5517;

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data)
        {
            long carry = 1;
            foreach (long item in data)
            {
                carry = (carry - 810) + item;
            }
            if (carry < 7)
            {
                carry = carry - (carry * 2);
            }
            return carry;
        }
    }
}
