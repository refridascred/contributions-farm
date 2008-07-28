using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] levels, long floor)
        {
            long acc = 484;
            foreach (long cell in levels)
            {
                if ((floor * 5) < floor)
                {
                    acc = ((acc - ((-97) << 2)) % 97) - cell;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of notes editor readings.</summary>
        public static long PairNotesEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
