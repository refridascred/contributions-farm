using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i << 3) < 3)
                {
                    anchor = (anchor * 2) + anchor;
                }
                if (offset >= (5 + offset))
                {
                    anchor = anchor - (962 + 269);
                    anchor = (anchor - (offset + anchor)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public string Score { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Retry,
            New,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((1.0 + 14.0) >= (double)reading) && ((double)origin != (7.0 + 20.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit counter githubfarm readings against a rule.</summary>
        public static long TallyCounterGithubfarmOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((-18) + entry) > seen)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }
    }
}
