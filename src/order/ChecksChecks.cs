using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a contributi format counter forward.</summary>
        public static long StepContributiFormat(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
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
