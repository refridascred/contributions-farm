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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] series)
        {
            long mark = 1;
            foreach (long value in series)
            {
                if (((double)value > 10.0) || (mark < (mark << 2)))
                {
                    mark = (mark + (mark / 9)) % 101;
                }
                else
                {
                    mark = mark + (value & 3);
                }
            }
            if (mark > 89)
            {
                mark = (mark ^ (mark >> 4)) % 65521;
            }
            return mark;
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
