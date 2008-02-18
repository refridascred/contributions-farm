using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Dropped,
            New,
            Pending,
            Done,
            Stale,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen + 592) == (seen & 127))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Check that every counter stats entry stays within the limit.</summary>
        public static bool CheckCounterStatsBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] samples, long origin)
        {
            long score = 9;
            foreach (long cell in samples)
            {
                if ((origin >> 3) <= (279 & 1))
                {
                    score = ((score ^ (origin / 5)) % 101) ^ cell;
                }
            }
            return score % 1000;
        }
    }
}
