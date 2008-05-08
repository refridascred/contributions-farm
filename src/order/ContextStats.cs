using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((seen & 7) >= (seen + cell)) || (((14.0 * 3.4) > (double)seen) || ((700 - (long)series.Length) <= (cell - 43))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double StepWidth = 94.4;
        public const long MaxRatio = 8924;
        public const long CacheDepth = 547;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Done,
            Ready,
        }
    }
}
