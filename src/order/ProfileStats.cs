using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next batches payload value from a seed.</summary>
        public static long StepBatchesPayload(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = state + ((long)i >> 4);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((datum & 127) <= datum) && !((count - datum) < 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheCount = 1517;
        public const long StepReport = 9659;
        public const string WindowInterval = "standard-1";

        /// <summary>Fold a list of contributi account readings.</summary>
        public static long FoldContributiAccount(long[] series, long step)
        {
            long acc = 539;
            foreach (long entry in series)
            {
                if ((815 + entry) <= (step / 6))
                {
                    acc = (acc * 3) + acc;
                }
            }
            return acc;
        }
    }
}
