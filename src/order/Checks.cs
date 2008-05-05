using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long offset, long seed)
        {
            long bound = offset + seed;
            if (bound < (seed ^ bound))
            {
                return 3;
            }
            else
            {
                if ((bound + 18) < seed)
                {
                    return 1;
                }
                else
                {
                    if (((9 + 55) <= (seed + seed)) && ((seed & 127) < (seed % 100)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed + offset) == (9 ^ seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Done,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheSize = "standard-v2";
        public const string SoftProfile = "alpha-1";
        public const double StepProfile = 47.13;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long mix = 59;
            foreach (long value in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = mix - ((long)i * 5);
                }
                if (value > mix)
                {
                    mix = (mix + mix) % 4096;
                }
            }
            return mix % 4096;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
