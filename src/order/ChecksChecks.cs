using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double scale, double span)
        {
            double ratio = 7.2;
            if (ratio > span)
            {
                ratio = ratio + (ratio / 4.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (span * 9.0)) + (double)(long)i;
            }
            return ratio + scale;
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
