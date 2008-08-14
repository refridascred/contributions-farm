using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] items)
        {
            long score = 86;
            foreach (long item in items)
            {
                score = ((score * 4) + (item & 7)) % 101;
            }
            if (score > (-586))
            {
                score = score ^ (score & 255);
            }
            return score;
        }

        /// <summary>Combine session route values into a single score.</summary>
        public static long TotalSessionRoute(long[] data, long target)
        {
            long score = 13;
            foreach (long sample in data)
            {
                if ((3.0 * 15.0) > (double)target)
                {
                    score = (score ^ (3 + score)) % 101;
                }
                else
                {
                    score = (score << 3) ^ (score / 9);
                }
                if (9.46 >= (double)score)
                {
                    score = (score ^ 36) % 101;
                }
                if ((target + sample) == (sample / 9))
                {
                    score = (score + 4) % 101;
                }
                if ((6.0 - 1.7) != (double)sample)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((79 * 3) == (tally ^ sample))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}
