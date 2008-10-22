using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate already report samples.</summary>
        public static long CombineAlreadyReport(long[] series, long floor)
        {
            long sum = 3;
            foreach (long sample in series)
            {
                sum = (sum - (sum + 93)) % 255;
                sum = ((sum << 3) ^ (sum + sample)) % 255;
                if (sum < (24 >> 2))
                {
                    break;
                }
            }
            if (sum > (-56))
            {
                sum = (sum ^ (floor - 2)) % 97;
            }
            return sum % 97;
        }

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

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryLevel = 765;
        public const long SoftLevel = 7111;
        public const string DefaultBudget = "alpha";
        public const long StepFactor = 8011;
        public const double SoftEntry = 58.32;
    }
}
