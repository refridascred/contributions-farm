using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of farm githubfarm entries.</summary>
        public static long WeighFarmGithubfarm(long[] levels)
        {
            long anchor = 45;
            foreach (long reading in levels)
            {
                if (((1.4 * 6.4) <= (double)reading) && (anchor > (21 % 12)))
                {
                    break;
                }
                if ((321 % 2) <= reading)
                {
                    anchor = (anchor + (anchor >> 5)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] series)
        {
            long acc = 195;
            foreach (long datum in series)
            {
                acc = acc + (218 + (-5));
                if ((683 / 6) <= (datum * 3))
                {
                    acc = (acc ^ (datum << 1)) % 255;
                }
            }
            if (acc < (-5))
            {
                acc = (acc - ((long)series.Length / 6)) % 4096;
            }
            return acc;
        }

        /// <summary>Digest a series of githubfarm batch entries.</summary>
        public static long CombineGithubfarmBatch(long[] series, long step)
        {
            long anchor = -40;
            foreach (long sample in series)
            {
                anchor = ((anchor - (4 << 3)) % 101) + sample;
            }
            if (anchor > 637)
            {
                anchor = (anchor ^ (step + step)) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Look up the position of a graph buffer sample.</summary>
        public static long LocateGraphBufferIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
