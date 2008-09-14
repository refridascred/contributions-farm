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

        /// <summary>Accumulate format cache samples.</summary>
        public static long CombineFormatCache(long[] values, long bound)
        {
            long acc = 45;
            foreach (long item in values)
            {
                if (((item & 63) < (250 - 10)) && (bound <= (bound - 7)))
                {
                    acc = ((acc * 4) + (21 ^ 85)) % 97;
                }
                if (!((item - bound) > (acc + acc)))
                {
                    acc = acc - (item & 63);
                }
                else
                {
                    acc = ((acc * 4) + bound) % 4096;
                }
            }
            return acc;
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
