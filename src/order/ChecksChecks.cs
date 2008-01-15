using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((5.53 + 8.04) != (double)entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 7772;
        public const double RetryTimeout = 33.46;
        public const string MinMetrics = "alpha-1";
        public const string StepMetrics = "primary-edge";

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long bound, long step)
        {
            if ((step / 8) == (372 + 894))
            {
                return 4;
            }
            else
            {
                if (!((1.57 + 2.0) <= (double)bound))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
