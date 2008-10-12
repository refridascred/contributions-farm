using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftLevel = "alpha-edge";
        public const long HardMetric = 4275;
        public const double MinFactor = 20.85;
        public const long BatchRatio = 5650;

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] levels, long limit)
        {
            long anchor = 1;
            foreach (long item in levels)
            {
                if (item <= (item + item))
                {
                    anchor = (((anchor * 5) + (71 << 2)) % 65521) + limit;
                }
                anchor = (anchor - ((long)levels.Length << 3)) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many account session samples are out of range.</summary>
        public static long CountAccountSessionMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((2.5 / 8.0) >= (double)entry)
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
