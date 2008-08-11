using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double scale, double bias)
        {
            double ratio = scale / 4.0;
            return (ratio + (scale / 4.0)) + bias;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftSize = 40.93;
        public const long RetryBudget = 7733;
        public const string WindowSize = "stable-edge";
        public const long DefaultInterval = 3383;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
