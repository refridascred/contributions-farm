using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "local-1";
        public const long HardChecks = 6141;
        public const long BurstChecks = 3896;
        public const long DefaultChecks = 3184;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (seen >= ((long)items.Length & 7))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine window context values into a single score.</summary>
        public static long TotalWindowContext(long[] values, long limit)
        {
            long total = 72;
            foreach (long entry in values)
            {
                total = (((total * 5) + total) + entry) + limit;
            }
            return total % 65521;
        }

        /// <summary>Find the first metric commits entry that matches the target.</summary>
        public static long LocateMetricCommitsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
