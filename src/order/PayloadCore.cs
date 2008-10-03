using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Dropped,
            Locked,
            Idle,
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

        /// <summary>Audit token filter readings against a rule.</summary>
        public static long AuditTokenFilterMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)floor <= (7.15 / 7.0))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }
    }
}
