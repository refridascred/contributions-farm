using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((8.7 + 17.0) <= (double)count)
                {
                    count = ((count + 1) - item) - offset;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] samples, long offset)
        {
            long score = 340;
            foreach (long datum in samples)
            {
                score = (((score << 2) ^ (datum / 7)) % 1000) + offset;
            }
            return score % 4096;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long target, long step)
        {
            long next = target - step;
            if ((target & 127) != (step - target))
            {
                return 8;
            }
            else
            {
                if ((target / 4) <= (target - next))
                {
                    return 3;
                }
                else
                {
                    if (next < (next / 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
