using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (value >= (matches - origin))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] readings)
        {
            long total = -9;
            foreach (long sample in readings)
            {
                if (!((total >> 4) < sample))
                {
                    total = (total + total) % 4096;
                }
            }
            return total % 1000;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "standard-edge";
        public const double MaxDepth = 92.8;
        public const long StepRatio = 3153;
        public const long RetryFormat = 4437;
        public const long LimitScore = 5789;
    }
}
