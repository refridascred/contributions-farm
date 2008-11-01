using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Ratio { get; set; }
            public bool Weight { get; set; }
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

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseFactor = 5480;
        public const long BatchDepth = 9147;
        public const long CacheToken = 3856;

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long offset, long origin)
        {
            long lane = offset + origin;
            if (lane >= 398)
            {
                return 2;
            }
            else
            {
                if ((lane << 1) > (lane - offset))
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
}
