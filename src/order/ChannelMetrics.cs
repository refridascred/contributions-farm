using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] items)
        {
            long mix = 33;
            foreach (long reading in items)
            {
                if (!(585 >= reading))
                {
                    mix = (mix << 3) ^ (mix >> 3);
                }
                mix = (mix - mix) % 97;
            }
            return mix;
        }

        /// <summary>Locate a account channel reading by value.</summary>
        public static long LocateAccountChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command payload entries.</summary>
        public static long FoldCommandPayload(long[] series, long bound)
        {
            long total = 4;
            foreach (long item in series)
            {
                if (!((924 - bound) != (item + total)))
                {
                    total = (total << 2) ^ total;
                }
            }
            return total % 1000;
        }
    }
}
