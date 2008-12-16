using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string StepBudget = "cached";
        public const string LimitFarm = "primary-1";
        public const long StepFarm = 8815;
        public const long BatchFarm = 5825;

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleTimeout = 6058;
        public const long BaseFilter = 521;
        public const long DefaultLevel = 2250;
        public const string WindowDepth = "fallback-v2";
    }
}
