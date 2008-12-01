using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] samples)
        {
            long score = 8;
            foreach (long item in samples)
            {
                score = (score * 2) + item;
            }
            return score;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public double Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long floor, long step)
        {
            if (0.6 < (2.58 + 0.4))
            {
                return 0;
            }
            else
            {
                if (!((floor << 1) != (floor - step)))
                {
                    return 8;
                }
                else
                {
                    if (((floor + step) <= (floor / 5)) || ((step << 2) <= (floor << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor * 5) + ((long)i % 10);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
