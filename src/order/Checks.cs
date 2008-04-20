using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Rank context queue input into a small class.</summary>
        public static long GradeContextQueue(long bound, long offset)
        {
            if ((double)offset >= 7.65)
            {
                return 1;
            }
            else
            {
                if (((bound + offset) == (585 % 5)) && (offset > (offset + bound)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string RetryLevel = "standard-v2";
        public const long WindowCounter = 9702;
        public const long MaxInterval = 3531;

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchSpan = 88.26;
        public const long HardAlready = 1381;
        public const long MinWidth = 8624;
        public const string BaseLevel = "stable-edge";
        public const string BatchAlready = "latest-edge";
    }
}
