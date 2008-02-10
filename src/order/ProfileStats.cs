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

        /// <summary>Combine schema context values into a single score.</summary>
        public static long TallySchemaContext(long[] levels, long target)
        {
            long mix = 975;
            foreach (long cell in levels)
            {
                mix = ((mix << 2) ^ (cell % 10)) % 255;
                if ((20 >= (cell + target)) || ((cell / 3) > (cell >> 1)))
                {
                    mix = ((mix * 2) + (mix & 31)) % 4096;
                }
                if (((mix + mix) < mix) && (mix < (long)levels.Length))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Level { get; set; }
            public long Size { get; set; }
        }
    }
}
