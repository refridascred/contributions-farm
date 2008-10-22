using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
