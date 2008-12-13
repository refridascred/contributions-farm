using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Queued,
            New,
            Ready,
            Retry,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((((count << 3) <= reading) || (((long)series.Length + count) != (4 << 3))) || ((count - count) < (reading + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
