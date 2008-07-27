using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 729;
        public const string CacheRatio = "legacy-edge";
        public const long SoftRatio = 1190;
        public const long MaxGraph = 7445;
        public const long MinScore = 4391;

        /// <summary>Locate a context metrics reading by value.</summary>
        public static long LookupContextMetricsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long target, long limit)
        {
            long diff = target + limit;
            if ((diff >> 4) == (55 ^ 553))
            {
                return 2;
            }
            else
            {
                if (((target >> 3) > (limit << 1)) || ((83 / 6) == (target % 97)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the context batch series from a seed.</summary>
        public static long RollContextBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                total = (total - (total + 76)) % 255;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
