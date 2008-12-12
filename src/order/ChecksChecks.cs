using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 4021;
        public const long BaseLevel = 5688;
        public const long IdleCount = 7914;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Look up the position of a counter checks sample.</summary>
        public static long FindCounterChecksIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
