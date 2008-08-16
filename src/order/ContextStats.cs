using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of entry cluster readings.</summary>
        public static long CompareEntryClusterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Token { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of channel already entries.</summary>
        public static long TallyChannelAlready(long[] readings, long seed)
        {
            long state = 44;
            foreach (long item in readings)
            {
                state = (state - (seed / 9)) - item;
            }
            if (state < 168)
            {
                state = state + (946 + state);
            }
            return state;
        }

        /// <summary>Match up cluster batch samples.</summary>
        public static long PairClusterBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
