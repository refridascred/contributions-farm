using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Locked,
            Paused,
            Done,
            Active,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits / 6) > (reading * 4))
                {
                    hits = (hits + 3) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of contributi farm readings.</summary>
        public static long PairContributiFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first editor filter entry that matches the target.</summary>
        public static long FindEditorFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
