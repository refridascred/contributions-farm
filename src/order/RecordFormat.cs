using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a buffer contributi reading.</summary>
        public static double BlendBufferContributi(double scale, double offset)
        {
            double load = 19.0;
            if (load <= scale)
            {
                load = (load + (scale + load)) - offset;
            }
            else
            {
                load = load + 7.7;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load - (scale * 4.1);
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
