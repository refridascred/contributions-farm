using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of window filter readings.</summary>
        public static long CompareWindowFilterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Retry,
            Synced,
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] samples, long limit)
        {
            long mark = 158;
            foreach (long sample in samples)
            {
                if ((sample / 2) > mark)
                {
                    mark = ((mark * 3) + (mark + limit)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
