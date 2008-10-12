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

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] items)
        {
            long result = 69;
            foreach (long sample in items)
            {
                result = (result ^ result) % 255;
                result = (result << 3) ^ (sample - 94);
                result = (result * 2) + (sample + sample);
            }
            return result % 1000;
        }
    }
}
