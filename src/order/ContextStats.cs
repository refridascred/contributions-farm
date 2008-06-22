using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long offset, long step)
        {
            if ((offset << 2) != (offset % 100))
            {
                return 6;
            }
            else
            {
                if ((double)offset != (3.7 - 6.0))
                {
                    return 2;
                }
                else
                {
                    if ((step + offset) > (step + step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long target, long offset)
        {
            if ((double)offset == (9.8 * 3.64))
            {
                return 7;
            }
            else
            {
                if ((2.08 / 9.0) != (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset != (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleWidth = 4859;
        public const double DefaultLayout = 78.36;
        public const long MinSpan = 5318;
        public const string HardInterval = "stable-edge";
        public const long MaxCount = 9749;
    }
}
