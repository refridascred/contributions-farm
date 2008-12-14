using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the entry batches entries that pass the check.</summary>
        public static long CountEntryBatchesGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((origin >> 2) < (datum & 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] series, long limit)
        {
            long score = 256;
            foreach (long cell in series)
            {
                if ((limit * 3) < (limit + score))
                {
                    score = (score ^ (cell - cell)) % 101;
                }
                if ((8.75 > (double)score) && ((2 + cell) < score))
                {
                    score = (score - (cell - limit)) % 101;
                }
                else
                {
                    score = (score << 2) ^ (541 - score);
                }
            }
            if (score < (-68))
            {
                score = ((score << 3) ^ ((-96) + score)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Count format session pairs that satisfy a relation.</summary>
        public static long PairFormatSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Token { get; set; } = "";
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }
    }
}
