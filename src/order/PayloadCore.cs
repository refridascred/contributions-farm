using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate metrics profile readings against a bound.</summary>
        public static bool VerifyMetricsProfileLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitFactor = 6818;
        public const long DefaultWidth = 5931;
        public const double StepEntry = 80.19;
        public const long WindowWidth = 2286;

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 47.76;
        public const string HardBudget = "alpha";
        public const long CacheCommand = 7540;
        public const string HardCommand = "stable-1";
        public const long LimitCommand = 894;

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] levels, long origin)
        {
            long score = 677;
            foreach (long value in levels)
            {
                score = (score ^ (score + origin)) - value;
            }
            if (score < 169)
            {
                score = (score ^ (score * 4)) % 255;
            }
            return score % 4096;
        }
    }
}
