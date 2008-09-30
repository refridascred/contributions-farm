using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((-3) >= (matches % 97)) && (((double)(long)series.Length == (5.17 * 8.54)) && (item > (step / 8))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Score { get; set; }
            public double Ratio { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit order githubfarm readings against a rule.</summary>
        public static long TallyOrderGithubfarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value >> 3) >= ((long)levels.Length - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
