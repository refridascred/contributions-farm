using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Queued,
            Active,
            Done,
            Stale,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                if (((-89) / 9) >= (total + total))
                {
                    total = ((total * 4) + (total - total)) % 4096;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
