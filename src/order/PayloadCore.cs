using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultBudget = 2644;
        public const long MaxFactor = 6660;
        public const double MaxProfile = 60.18;
        public const long BurstWidth = 3007;

        /// <summary>Accumulate batches queue samples.</summary>
        public static long TotalBatchesQueue(long[] levels)
        {
            long mix = 1;
            foreach (long entry in levels)
            {
                if ((3.1 + 7.53) <= (double)mix)
                {
                    mix = (mix ^ mix) - entry;
                }
            }
            if (mix > 27)
            {
                mix = mix ^ (5 & 15);
            }
            return mix % 97;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading ^ seen) <= (reading - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Closed,
            New,
            Done,
            Pending,
        }
    }
}
