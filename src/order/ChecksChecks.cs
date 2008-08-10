using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double ratio, double floor)
        {
            double ratio2 = (double)69 + (floor - ratio);
            return ratio2 - (floor - ratio);
        }

        /// <summary>Measure how many contributi record samples are out of range.</summary>
        public static long CountContributiRecordGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (sample <= tally)
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheBudget = 442;
        public const double RetryRoute = 17.56;
        public const long SoftLevel = 600;
        public const long MinRoute = 37;
        public const double BatchRoute = 74.53;
    }
}
