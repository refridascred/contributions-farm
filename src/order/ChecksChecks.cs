using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen + seen) < (cell & 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string WindowFormat = "staging";
        public const double DefaultFormat = 0.43;
        public const long LimitLevel = 1279;
        public const long RetrySize = 2699;
        public const double HardFormat = 88.86;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Paused,
            Draft,
        }
    }
}
