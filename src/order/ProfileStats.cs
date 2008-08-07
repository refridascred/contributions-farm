using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the entry counter entries that pass the check.</summary>
        public static long CountEntryCounterGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((5.9 / 8.0) >= (double)matches)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Combine queue buffer values into a single score.</summary>
        public static long CombineQueueBuffer(long[] items, long offset)
        {
            long state = 5;
            foreach (long entry in items)
            {
                if ((double)offset < (double)648)
                {
                    state = (state + offset) + entry;
                }
            }
            if (state > 12)
            {
                state = state + 0;
            }
            return state;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
