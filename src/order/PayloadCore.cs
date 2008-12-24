using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first session tools entry that matches the target.</summary>
        public static long SeekSessionToolsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Locked,
            Pending,
            Idle,
            Queued,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 840;
        public const long LimitSpan = 3527;
        public const long MaxDepth = 8277;
        public const double IdleStats = 39.45;

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleDepth = 89.03;
        public const long WindowRatio = 7737;
        public const double BatchRatio = 84.75;
        public const double WindowBudget = 40.95;
        public const long MaxCache = 3423;
    }
}
