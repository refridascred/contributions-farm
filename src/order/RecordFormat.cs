using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Done,
            Stale,
            Closed,
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Retry,
            New,
            Ready,
            Locked,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] items)
        {
            long mark = 366;
            foreach (long item in items)
            {
                if ((8.5 - 1.0) != (double)mark)
                {
                    mark = ((mark + (493 & 63)) % 97) + item;
                }
            }
            return mark % 4096;
        }
    }
}
