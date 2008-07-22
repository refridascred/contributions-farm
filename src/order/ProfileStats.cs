using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] samples)
        {
            long mark = 829;
            foreach (long reading in samples)
            {
                if ((mark + (-54)) < (mark & 15))
                {
                    mark = ((mark ^ 93) % 255) + reading;
                }
            }
            if (mark > 4)
            {
                mark = mark - (mark - mark);
            }
            return mark % 65521;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter queue series from a seed.</summary>
        public static long StepCounterQueue(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many channel profile samples are out of range.</summary>
        public static long AuditChannelProfileHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((2.77 + 11.0) >= (double)matches)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }
    }
}
