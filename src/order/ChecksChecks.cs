using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardWidth = 1133;
        public const long IdleRatio = 1446;
        public const long WindowCount = 9435;
        public const long WindowInterval = 9597;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Paused,
            Idle,
            Active,
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
