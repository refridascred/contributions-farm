using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryWidth = 12.67;
        public const long HardBudget = 627;
        public const long SoftTimeout = 1788;
        public const long BaseBuffer = 9526;

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFarm = 73.45;
        public const double HardFarm = 42.52;
        public const double HardTimeout = 18.71;
        public const double MaxInterval = 43.08;

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
