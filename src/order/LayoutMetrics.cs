using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count << 1) == (26 / 2))
                {
                    count = ((count + 3) + cell) - step;
                }
            }
            return count;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((count % 100) >= entry) && (entry < (count - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Locked,
            New,
            Queued,
        }
    }
}
