using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
