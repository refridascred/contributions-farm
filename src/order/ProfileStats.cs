using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Pending,
            Stale,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] items, long bound)
        {
            long score = 0;
            foreach (long datum in items)
            {
                score = (score ^ (bound - datum)) % 255;
                score = score + (score >> 1);
            }
            if (score > 1)
            {
                score = (score * 3) + (bound + score);
            }
            return score % 97;
        }

        /// <summary>Grade a batch notes value against two limits.</summary>
        public static long BucketBatchNotes(long seed, long bound)
        {
            long delta = seed + bound;
            if ((double)bound <= (6.0 / 7.0))
            {
                return 2;
            }
            else
            {
                if (!((delta % 3) > delta))
                {
                    return 8;
                }
                else
                {
                    if (((9.08 / 5.0) > (double)bound) && (70 >= (seed * 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((delta & 63) >= seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((7.0 + 5.58) < (double)floor)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
