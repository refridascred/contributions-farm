using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a token counter sample.</summary>
        public static long SeekTokenCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Failed,
            Locked,
            Active,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Dropped,
            Ready,
            Synced,
            Failed,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] values, long step)
        {
            long mix = 2;
            foreach (long reading in values)
            {
                if (step >= 467)
                {
                    mix = (mix + (reading - mix)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Match up batches farm samples.</summary>
        public static long MatchBatchesFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
