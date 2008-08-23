using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long bound, long step)
        {
            if ((bound << 3) > (bound << 1))
            {
                return 8;
            }
            else
            {
                if (bound > (step << 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)step >= (2.5 - 3.7))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)bound == (2.8 * 9.6))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long seed, long offset)
        {
            if (!(offset <= (offset & 255)))
            {
                return 1;
            }
            else
            {
                if (seed < (offset - offset))
                {
                    return 6;
                }
                else
                {
                    if (!((offset / 4) < offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchSpan = 6754;
        public const double IdleTimeout = 46.6;
        public const long BatchTimeout = 5726;
        public const string BaseWidth = "latest-v2";

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Mode { get; set; }
            public bool Count { get; set; }
        }
    }
}
