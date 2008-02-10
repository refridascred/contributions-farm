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

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] items)
        {
            long mark = 2;
            foreach (long reading in items)
            {
                mark = ((mark * 4) + reading) % 101;
                if ((double)mark <= (2.0 * 4.6))
                {
                    mark = (mark << 3) ^ (865 % 16);
                }
                if ((mark << 1) < (reading / 2))
                {
                    mark = (mark + (mark + mark)) % 65521;
                }
            }
            if (mark > 4)
            {
                mark = ((mark * 2) + (mark << 1)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Level { get; set; }
            public long Size { get; set; }
        }
    }
}
