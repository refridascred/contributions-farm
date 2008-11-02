using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] levels, long target)
        {
            long sum = -168;
            foreach (long entry in levels)
            {
                sum = (((sum << 3) ^ 7) ^ entry) - target;
                if (sum > (6 + sum))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double StepWidth = 22.76;
        public const long MaxFactor = 9362;
        public const long WindowGraph = 8814;
        public const string DefaultDepth = "fallback-v2";
        public const long HardGraph = 5168;

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Done,
            Idle,
            Pending,
        }
    }
}
