using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitSpan = 7627;
        public const string SoftContributi = "alpha-edge";
        public const long CacheContributi = 633;

        /// <summary>Define order limits and defaults.</summary>
        public const long MinFactor = 9247;
        public const long BurstOrder = 8734;
        public const long RetryBudget = 8500;
        public const long DefaultCount = 2102;
        public const double BaseOrder = 17.83;

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
