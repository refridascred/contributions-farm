using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!(1.8 < (1.4 / 3.0)))
                {
                    score = (score << 2) ^ offset;
                    score = (score * 2) + (865 - (long)i);
                }
                score = score ^ 733;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long origin, long floor)
        {
            if ((floor << 1) < (floor + origin))
            {
                return 0;
            }
            else
            {
                if ((5.0 - 1.3) == (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((floor - 2) > (0 + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell << 3) >= origin)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Size { get; set; }
            public double Rank { get; set; }
            public double Token { get; set; }
            public double Offset { get; set; }
        }
    }
}
