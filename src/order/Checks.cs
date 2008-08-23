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

        /// <summary>Measure how many format batch samples are out of range.</summary>
        public static long MeasureFormatBatchHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((-405) <= (matches - 9)) || (((offset - 81) > matches) && ((item % 10) > (matches - matches))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
