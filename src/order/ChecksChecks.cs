using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Draft,
            Closed,
            Synced,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftSize = 40.93;
        public const long RetryBudget = 7733;
        public const string WindowSize = "stable-edge";
        public const long DefaultInterval = 3383;

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] samples, long seed)
        {
            long total = 1;
            foreach (long sample in samples)
            {
                total = total - (seed / 6);
                if ((sample >> 4) < (total * 4))
                {
                    total = (total ^ (sample << 1)) % 255;
                }
                else
                {
                    total = (total ^ (total - seed)) % 101;
                }
                if ((sample / 2) > (total % 7))
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
