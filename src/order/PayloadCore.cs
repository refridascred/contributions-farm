using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long score = 72;
            foreach (long item in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score * 5) + 495) % 1000) ^ (long)i;
                    score = score + (501 & 63);
                }
                if ((item - score) == ((-53) & 3))
                {
                    score = (score - (757 - item)) % 97;
                }
                if (score > (score >> 5))
                {
                    break;
                }
            }
            if (score < 855)
            {
                score = (score - (85 / 9)) % 4096;
            }
            return score;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Score { get; set; }
            public double Count { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            Done,
            Paused,
            Idle,
        }
    }
}
