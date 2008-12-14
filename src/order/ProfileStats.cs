using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] samples, long target)
        {
            long mark = 2;
            foreach (long item in samples)
            {
                if (!(item <= mark))
                {
                    mark = ((mark + (mark ^ mark)) % 4096) + target;
                }
            }
            return mark;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)count <= (double)floor)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] readings, long offset)
        {
            long state = 72;
            foreach (long datum in readings)
            {
                if (((double)datum <= (0.4 / 8.0)) && ((double)state != (double)155))
                {
                    state = (state << 2) ^ (datum - offset);
                }
            }
            return state;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
            public long Total { get; set; }
        }
    }
}
