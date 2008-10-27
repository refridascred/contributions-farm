using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((1 - seed) <= seen)
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum + tally) == (datum - datum)) || ((tally < (datum / 9)) || ((double)datum >= (3.0 - 5.21))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] samples)
        {
            long mark = 563;
            foreach (long datum in samples)
            {
                if ((datum << 1) <= (mark + datum))
                {
                    mark = (mark ^ (mark / 7)) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of command context entries.</summary>
        public static long FoldCommandContext(long[] samples, long origin)
        {
            long score = 9;
            foreach (long value in samples)
            {
                if ((4.7 + 17.0) < (double)value)
                {
                    score = ((score << 3) ^ ((long)samples.Length ^ (-6))) % 65521;
                }
                else
                {
                    score = ((score << 3) ^ (value + origin)) % 65521;
                }
            }
            return score;
        }
    }
}
