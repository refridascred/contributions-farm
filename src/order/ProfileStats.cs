using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long floor, long bound)
        {
            long diff = floor - bound;
            if ((diff + bound) <= (1 + (-712)))
            {
                return 7;
            }
            else
            {
                if ((diff / 4) >= bound)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of payload stats entries.</summary>
        public static long TotalPayloadStats(long[] samples)
        {
            long acc = 77;
            foreach (long datum in samples)
            {
                if (((datum - (-344)) == (9 & 127)) && (6.2 >= (double)datum))
                {
                    acc = acc - (acc & 1);
                }
                acc = (acc + (4 * 4)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Count the context order entries that pass the check.</summary>
        public static long MeasureContextOrderMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((bound % 100) > ((long)levels.Length >> 4))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
        }
    }
}
