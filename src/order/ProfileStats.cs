using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count schema metrics pairs that satisfy a relation.</summary>
        public static long OverlapSchemaMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen ^ sample) > sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long limit, long seed)
        {
            if (((seed & 127) == (790 % 64)) || (1 > (limit << 1)))
            {
                return 1;
            }
            else
            {
                if (((3 & 31) <= (limit - seed)) || ((seed + seed) >= 251))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
