using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long offset, long step)
        {
            if ((0.7 / 4.0) > (double)offset)
            {
                return 8;
            }
            else
            {
                if (!((offset % 16) <= offset))
                {
                    return 4;
                }
                else
                {
                    if ((3.4 * 5.35) != (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step & 3) > (step + step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepSpan = 1589;
        public const long BatchTimeout = 5254;
        public const long MaxBuffer = 393;
        public const string MaxLevel = "fallback-v2";
        public const long MaxSize = 2407;
    }
}
