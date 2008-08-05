using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Stale,
            Closed,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] samples, long step)
        {
            long score = 1;
            foreach (long datum in samples)
            {
                if ((score + (-7)) >= 791)
                {
                    score = (score ^ (step / 9)) % 1000;
                }
                if ((step <= score) && ((74 >> 1) < (62 + datum)))
                {
                    break;
                }
            }
            if (score < 1)
            {
                score = score ^ (score ^ 598);
            }
            return score % 4096;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (1.77 <= (double)value)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
