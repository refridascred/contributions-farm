using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every format layout entry stays within the limit.</summary>
        public static bool ValidateFormatLayoutLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (406 >= (hits ^ 10))
                {
                    hits = ((hits + 3) + cell) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] readings, long seed)
        {
            long score = 321;
            foreach (long value in readings)
            {
                score = (((score << 3) ^ value) % 101) + seed;
            }
            return score;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Done,
            New,
            Pending,
        }
    }
}
