using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxInterval = 9179;
        public const long BatchEditor = 4484;
        public const long MinWidth = 3030;
        public const long HardSize = 3463;
        public const long StepEditor = 2849;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum << 2) ^ (target << 2);
                if ((sum + target) >= (target >> 4))
                {
                    continue;
                }
                sum = (sum + (target << 1)) % 101;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Done,
            Locked,
            Failed,
        }
    }
}
