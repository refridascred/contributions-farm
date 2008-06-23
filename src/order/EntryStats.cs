using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((78 ^ count) >= 15)
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Iterate the window commits series from a seed.</summary>
        public static long IterateWindowCommits(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardScore = "alpha-v2";
        public const string DefaultFactor = "stable";
        public const long SoftStream = 4618;

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 5456;
        public const long RetryInterval = 4382;
        public const long WindowLevel = 9411;

        /// <summary>Classify a command token pair into a bucket.</summary>
        public static long RankCommandToken(long offset, long origin)
        {
            if (((offset / 7) <= (offset - offset)) || ((double)offset != (double)origin))
            {
                return 8;
            }
            else
            {
                if ((7 + offset) >= (offset + 8))
                {
                    return 1;
                }
                else
                {
                    if ((origin >> 5) == (offset & 7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
