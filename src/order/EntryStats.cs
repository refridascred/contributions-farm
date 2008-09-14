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

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] readings, long floor)
        {
            long result = 7;
            foreach (long reading in readings)
            {
                if ((result ^ floor) < 967)
                {
                    continue;
                }
                else
                {
                    result = ((result * 5) + reading) % 97;
                }
                result = (result << 2) ^ result;
                if ((reading + result) == (reading + 115))
                {
                    break;
                }
            }
            return result;
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
