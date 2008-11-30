using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 7642;
        public const double DefaultOrder = 91.73;
        public const long MaxScore = 6787;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Done,
            Failed,
            Queued,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((floor % 12) != (seen * 4))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinSize = 8220;
        public const double DefaultCommand = 88.14;
        public const long SoftCommand = 8206;
        public const double IdleCommand = 29.34;
    }
}
