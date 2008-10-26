using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of context command readings.</summary>
        public static long FoldContextCommand(long[] data, long origin)
        {
            long total = 58;
            foreach (long reading in data)
            {
                if (1.22 <= (double)reading)
                {
                    total = total + (875 << 3);
                }
                else
                {
                    total = (total * 3) + (origin << 2);
                }
            }
            return total % 1000;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] samples)
        {
            long mark = 1;
            foreach (long datum in samples)
            {
                if ((2.1 >= 14.0) || ((datum - 41) >= (datum * 3)))
                {
                    mark = (mark + (datum - 523)) % 65521;
                }
            }
            if (mark < 12)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark % 4096;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] data)
        {
            long mark = 597;
            foreach (long item in data)
            {
                if ((mark << 1) < item)
                {
                    mark = mark ^ (757 + mark);
                }
            }
            if (mark < 400)
            {
                mark = (mark - (mark - mark)) % 97;
            }
            return mark;
        }
    }
}
