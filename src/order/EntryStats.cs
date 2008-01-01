using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((((target % 3) >= (4 + target)) && ((target / 8) < hits)) || ((cell + cell) == (822 ^ 344)))
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

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Synced,
            Stale,
            Active,
            New,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] data, long floor)
        {
            long result = 945;
            foreach (long value in data)
            {
                if ((value - floor) == (0 - value))
                {
                    result = (result - (result ^ result)) % 97;
                }
                else
                {
                    result = (result - floor) % 255;
                }
            }
            return result;
        }
    }
}
