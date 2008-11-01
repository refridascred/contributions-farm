using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long seed, long limit)
        {
            if ((double)limit < (12.0 + 4.0))
            {
                return 5;
            }
            else
            {
                if (!((seed >> 4) > seed))
                {
                    return 2;
                }
                else
                {
                    if (seed < (25 + limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((limit - seed) <= (seed & 7)) || ((seed + seed) < (seed - 73)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell < (cell + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Level { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
