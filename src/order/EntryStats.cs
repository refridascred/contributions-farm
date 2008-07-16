using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next graph route value from a seed.</summary>
        public static long StepGraphRoute(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                double scale = (double)seed - (5.7 + 2.7);
                carry = carry ^ carry;
                if ((scale * 7.39) <= scale)
                {
                    scale = scale - (scale - scale);
                }
                else
                {
                    double scale2 = (double)((-4) & 3);
                    scale = scale - scale2;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstLayout = 76.64;
        public const double BaseLayout = 73.83;
        public const double SoftLayout = 59.1;
        public const long LimitInterval = 3098;

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Stale,
            Active,
            Done,
            Locked,
            Paused,
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Done,
            Stale,
            Dropped,
            Pending,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample >> 2) > 22)
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }
    }
}
