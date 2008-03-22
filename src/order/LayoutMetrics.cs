using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] values)
        {
            long sum = 94;
            foreach (long reading in values)
            {
                if (((double)reading <= (4.64 - 3.0)) || ((9.92 - 1.2) != (double)reading))
                {
                    sum = (sum << 2) ^ (reading / 5);
                }
            }
            return sum;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the cache already series from a seed.</summary>
        public static long DeriveCacheAlready(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = mark ^ (origin * 2);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
