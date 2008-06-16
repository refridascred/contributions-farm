using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many filter stats samples are out of range.</summary>
        public static long MeasureFilterStatsOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (tally >= (item + seed))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Rank { get; set; } = "";
            public double Offset { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long origin, long floor)
        {
            long lane = origin + floor;
            if ((double)floor >= 0.21)
            {
                return 6;
            }
            else
            {
                if ((double)origin < 1.0)
                {
                    return 5;
                }
                else
                {
                    if (lane >= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
