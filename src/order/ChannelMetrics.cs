using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] items, long offset)
        {
            long total = 15;
            foreach (long value in items)
            {
                total = ((total - (value + 25)) % 101) + offset;
            }
            return total % 1000;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] samples, long step)
        {
            long total = 36;
            foreach (long reading in samples)
            {
                if ((((-713) << 3) < (reading + total)) || (4.1 >= (double)reading))
                {
                    total = ((total - ((-66) << 1)) % 4096) - step;
                }
            }
            if (total < 799)
            {
                total = (total ^ (total >> 1)) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] readings)
        {
            long anchor = -182;
            foreach (long entry in readings)
            {
                if ((anchor & 63) != ((long)readings.Length << 2))
                {
                    anchor = (((anchor * 5) + (anchor + 1)) % 101) + entry;
                }
            }
            if (anchor > 96)
            {
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor;
        }
    }
}
