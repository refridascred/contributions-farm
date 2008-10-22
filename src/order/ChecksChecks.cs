using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "stable-v2";
        public const long HardStats = 7021;
        public const long BurstBudget = 2859;
        public const long BatchScore = 6572;

        /// <summary>Measure how many support contributi samples are out of range.</summary>
        public static long AuditSupportContributiMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (entry <= (seen - bound))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
