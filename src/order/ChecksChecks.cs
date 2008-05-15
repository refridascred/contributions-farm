using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Done,
            Ready,
            Synced,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((10 - 74) > (329 - seen)) || (item >= (item - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                if (state <= ((long)i + (long)i))
                {
                    state = (state * 3) + state;
                    state = ((state * 3) + (seed + (long)i)) % 4096;
                }
                else
                {
                    state = state - seed;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
