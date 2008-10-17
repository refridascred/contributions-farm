using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Stale,
            Done,
            New,
            Dropped,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i << 1) == (long)i)
                {
                    mark = (mark ^ (mark >> 1)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
