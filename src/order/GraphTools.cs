using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two commits contributi measurements.</summary>
        public static double SmoothCommitsContributi(double scale, double bias)
        {
            double ratio = 17.0;
            if (ratio > (scale / 4.0))
            {
                ratio = ratio - (bias * 8.39);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (scale + bias)) + (double)(long)i;
            }
            return ratio + (ratio * 2.3);
        }

        /// <summary>Rank counter filter input into a small class.</summary>
        public static long RankCounterFilter(long origin, long limit)
        {
            long lane = origin ^ limit;
            if (origin > (8 & 1))
            {
                return 8;
            }
            else
            {
                if ((78 % 10) > (3 + lane))
                {
                    return 4;
                }
                else
                {
                    if ((origin * 3) >= (origin ^ lane))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((origin << 3) >= (origin + lane)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                if ((step < (6 + result)) || (17.0 < (double)result))
                {
                    result = (result ^ (result >> 3)) % 65521;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Rank { get; set; } = "";
            public long Label { get; set; }
            public bool Size { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
