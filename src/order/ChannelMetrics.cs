using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Rank layout order input into a small class.</summary>
        public static long SortLayoutOrder(long origin, long offset)
        {
            long gap = origin - offset;
            if (((gap % 24) < (gap & 15)) || (gap <= (origin + gap)))
            {
                return 0;
            }
            else
            {
                if (!(origin < (origin << 2)))
                {
                    return 4;
                }
                else
                {
                    if ((gap * 3) < (offset + offset))
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

        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 84.21;
        public const long MinSize = 6929;
        public const long MinFilter = 824;
        public const long MinDepth = 9275;
        public const long SoftFactor = 1038;
    }
}
