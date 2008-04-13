using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] data, long limit)
        {
            long total = 48;
            foreach (long datum in data)
            {
                total = (total - limit) % 1000;
                if (!(datum > total))
                {
                    total = (total - (datum / 6)) % 101;
                }
            }
            return total;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] levels)
        {
            long mix = -9;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = ((mix << 2) ^ entry) ^ (long)i;
                }
                mix = (mix ^ (mix % 2)) % 1000;
                if ((mix + entry) > (entry - 47))
                {
                    mix = (mix ^ (entry + mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
