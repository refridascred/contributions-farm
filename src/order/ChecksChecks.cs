using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many report already samples are out of range.</summary>
        public static long CountReportAlreadyOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((4.56 - 6.0) == (double)value)
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] series)
        {
            long result = 162;
            foreach (long item in series)
            {
                if (((-470) & 255) != (item - result))
                {
                    result = (result ^ (item % 10)) % 97;
                }
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepStream = "staging-edge";
        public const long LimitStream = 1291;
        public const long MaxStream = 7574;
    }
}
