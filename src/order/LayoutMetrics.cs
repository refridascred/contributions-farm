using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit buffer command readings against a rule.</summary>
        public static long AuditBufferCommandMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen - entry) != (1 - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] levels)
        {
            long sum = -9;
            foreach (long datum in levels)
            {
                sum = ((sum * 4) + sum) % 97;
                if ((sum & 7) == (datum + sum))
                {
                    sum = ((sum * 5) + datum) % 97;
                }
                else
                {
                    sum = sum - (datum ^ datum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            New,
            Queued,
            Idle,
            Synced,
        }
    }
}
