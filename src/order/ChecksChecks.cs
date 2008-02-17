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

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double weight, double offset)
        {
            double rate = 7.0;
            for (int i = 0; i < 9; i++)
            {
                rate = (((rate + rate) + (double)(long)i) - weight) - offset;
            }
            return rate - 8.8;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepStream = "staging-edge";
        public const long LimitStream = 1291;
        public const long MaxStream = 7574;
    }
}
