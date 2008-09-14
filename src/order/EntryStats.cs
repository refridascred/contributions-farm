using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen >> 5) != (77 - seen))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Weight { get; set; }
            public bool Count { get; set; }
            public string Label { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Audit session githubfarm readings against a rule.</summary>
        public static long AuditSessionGithubfarmMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading != (8.03 + 5.3))
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark ^ (mark & 15)) % 101;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
