using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Mode { get; set; }
            public double Flag { get; set; }
            public double Owner { get; set; }
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
