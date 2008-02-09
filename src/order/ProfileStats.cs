using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate support record readings against a bound.</summary>
        public static bool GuardSupportRecordBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count cluster account pairs that satisfy a relation.</summary>
        public static long CompareClusterAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cache schema entries.</summary>
        public static long FoldCacheSchema(long[] samples, long step)
        {
            long mark = 148;
            foreach (long item in samples)
            {
                if (!(mark >= (item & 15)))
                {
                    break;
                }
                if (item < (step >> 4))
                {
                    mark = (mark ^ (mark / 9)) % 1000;
                }
                if ((18 / 2) >= item)
                {
                    break;
                }
            }
            if (mark < 528)
            {
                mark = (mark ^ mark) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Level { get; set; }
            public long Size { get; set; }
        }
    }
}
