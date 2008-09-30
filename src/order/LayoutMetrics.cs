using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryInterval = "cached";
        public const long MaxSpan = 3695;
        public const string IdleStream = "latest";

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long offset, long bound)
        {
            long prev = offset - bound;
            if ((323 + prev) > prev)
            {
                return 4;
            }
            else
            {
                if (offset > prev)
                {
                    return 8;
                }
                else
                {
                    if (((bound ^ bound) == (offset >> 3)) && ((prev << 3) < (bound ^ offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset + prev) > bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
