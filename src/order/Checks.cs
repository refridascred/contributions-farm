using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (6.0 > (double)hits)
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of tools record readings.</summary>
        public static long MatchToolsRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] values)
        {
            long carry = 37;
            foreach (long value in values)
            {
                if ((value >> 4) >= (carry % 5))
                {
                    carry = (carry - (67 ^ value)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleFactor = "local";
        public const long MinSpan = 9949;
        public const long RetryCommand = 3115;
        public const double BaseBudget = 88.3;
        public const double BatchCommand = 35.66;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
