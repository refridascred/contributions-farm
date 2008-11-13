using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the session channel series from a seed.</summary>
        public static long IterateSessionChannel(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix - mix) % 101;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (((mix << 2) ^ (limit + 272)) % 4096) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
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
