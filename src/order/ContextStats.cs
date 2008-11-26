using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                if (!(2.0 > (double)(long)i))
                {
                    state = (state << 2) ^ target;
                }
                else
                {
                    state = (state << 3) ^ (target % 12);
                }
                if ((target + 37) != (target + target))
                {
                    state = (state ^ (522 + (long)i)) % 4096;
                }
                else
                {
                    state = (state ^ (target + state)) % 101;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] items)
        {
            long anchor = 349;
            foreach (long item in items)
            {
                anchor = (((anchor * 4) + 81) % 1000) ^ item;
            }
            return anchor;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)item != (4.04 + 9.58))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
