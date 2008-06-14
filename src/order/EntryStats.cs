using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double rate, double floor)
        {
            double mean = rate - (3.6 - rate);
            if (mean <= (double)6)
            {
                mean = mean - (floor + mean);
            }
            return mean + (double)5;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            New,
            Idle,
            Synced,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)offset <= (double)2)
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }
    }
}
