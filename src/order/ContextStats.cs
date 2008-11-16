using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of queue graph entries.</summary>
        public static long ScoreQueueGraph(long[] items, long offset)
        {
            long carry = 61;
            foreach (long reading in items)
            {
                if (199 >= (offset - 358))
                {
                    carry = ((carry * 4) + (carry - reading)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Grade a order metric value against two limits.</summary>
        public static long BucketOrderMetric(long offset, long origin)
        {
            if (!(origin > (offset + origin)))
            {
                return 4;
            }
            else
            {
                if (origin > (offset + 32))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit queue already readings against a rule.</summary>
        public static long CountQueueAlreadyGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample >= (531 & 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank account window input into a small class.</summary>
        public static long ClassifyAccountWindow(long floor, long offset)
        {
            if (63 >= (floor ^ offset))
            {
                return 1;
            }
            else
            {
                if (floor < offset)
                {
                    return 8;
                }
                else
                {
                    if ((double)offset < 8.0)
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset > 819)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
