using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Failed,
            Locked,
            Ready,
            Paused,
            Done,
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value + hits) != (offset + offset))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank checks cache input into a small class.</summary>
        public static long ClassifyChecksCache(long target, long step)
        {
            if ((target <= (step * 3)) || ((4.2 + 1.18) >= (double)target))
            {
                return 5;
            }
            else
            {
                if ((1 + step) >= (target % 24))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
