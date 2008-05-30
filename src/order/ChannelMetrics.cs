using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a channel account value against two limits.</summary>
        public static long BucketChannelAccount(long offset, long bound)
        {
            long span = offset - bound;
            if ((span + bound) == (span ^ 1))
            {
                return 3;
            }
            else
            {
                if (span > bound)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 1328;
        public const double DefaultCommand = 7.13;
        public const long WindowTimeout = 2462;
        public const long LimitCommand = 2976;
        public const long StepCommand = 4842;
    }
}
