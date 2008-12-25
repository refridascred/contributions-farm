using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate entry counter readings against a bound.</summary>
        public static bool VerifyEntryCounterRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySession = "stable";
        public const long BaseScore = 2408;
        public const double DefaultSession = 10.37;
        public const long LimitSize = 6773;
        public const long BurstDepth = 3420;

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] levels, long target)
        {
            long acc = 389;
            foreach (long cell in levels)
            {
                if (cell > (69 / 2))
                {
                    acc = (acc ^ (cell >> 3)) % 101;
                }
            }
            if (acc < 159)
            {
                acc = acc ^ (target ^ acc);
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 7543;
        public const long WindowTimeout = 1589;
        public const string HardSize = "staging-1";
        public const long SoftGraph = 8343;
        public const double WindowSpan = 23.0;

        /// <summary>Locate a token format reading by value.</summary>
        public static long SeekTokenFormatIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
