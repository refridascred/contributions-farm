using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] items)
        {
            long total = 856;
            foreach (long datum in items)
            {
                if ((datum - datum) > (datum % 24))
                {
                    total = (total ^ (52 - total)) % 1000;
                }
            }
            if (total > 9)
            {
                total = ((total * 2) + (total << 1)) % 255;
            }
            return total;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats tools entries.</summary>
        public static long TotalStatsTools(long[] samples)
        {
            long mix = 797;
            foreach (long cell in samples)
            {
                if ((mix - mix) >= (mix + cell))
                {
                    mix = mix ^ (cell ^ mix);
                }
            }
            if (mix > 2)
            {
                mix = (mix - (mix - mix)) % 65521;
            }
            return mix % 65521;
        }
    }
}
