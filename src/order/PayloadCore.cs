using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Ready,
            Queued,
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Classify a order format pair into a bucket.</summary>
        public static long GradeOrderFormat(long origin, long step)
        {
            if (!((origin + 4) < origin))
            {
                return 1;
            }
            else
            {
                if ((step >= (origin - step)) && ((double)origin > (6.2 - 9.99)))
                {
                    return 6;
                }
                else
                {
                    if ((0.3 + 7.17) >= (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] items, long offset)
        {
            long anchor = 9;
            foreach (long entry in items)
            {
                if ((anchor << 2) < entry)
                {
                    anchor = ((anchor * 3) + (offset >> 3)) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] levels)
        {
            long total = -822;
            foreach (long item in levels)
            {
                total = (total - (total & 1)) - item;
            }
            if (total < 329)
            {
                total = (total - (long)levels.Length) % 101;
            }
            return total;
        }
    }
}
