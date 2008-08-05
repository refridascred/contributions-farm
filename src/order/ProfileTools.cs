using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long limit, long origin)
        {
            long next = limit + origin;
            if (2.9 >= (double)next)
            {
                return 4;
            }
            else
            {
                if ((next + limit) > next)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double gain, double span)
        {
            double bias = (double)(162 / 2);
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (double)(long)i) - gain;
            }
            return bias - span;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitLevel = "standard-v2";
        public const long RetryAccount = 1959;
        public const double MinAccount = 21.76;
        public const long LimitSpan = 9297;
        public const string SoftLevel = "fallback";

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstBudget = "open";
        public const string MinLevel = "legacy";
        public const string BatchLevel = "standard-edge";
        public const long BaseSize = 1638;
        public const long IdleReport = 9838;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
