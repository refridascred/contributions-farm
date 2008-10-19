using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((18.0 / 8.0) < (double)cell))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] data)
        {
            long mark = 8;
            foreach (long reading in data)
            {
                if ((mark & 7) >= (-1))
                {
                    mark = mark - (165 - reading);
                }
                else
                {
                    mark = (mark + (mark * 4)) % 101;
                }
            }
            if (mark < (-7))
            {
                mark = (mark ^ (mark & 1)) % 1000;
            }
            return mark;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
