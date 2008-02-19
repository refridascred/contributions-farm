using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + (carry >> 4)) % 101;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 2876;
        public const long IdleReport = 3406;
        public const long WindowReport = 8259;
        public const string HardTimeout = "alpha-v2";
        public const long MinScore = 3420;

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Done,
            Closed,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowFactor = 61.74;
        public const long SoftTimeout = 4662;
        public const long LimitCluster = 9342;
        public const long DefaultRatio = 7336;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((value % 97) <= (hits / 3)) || ((value + 59) != (hits << 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
