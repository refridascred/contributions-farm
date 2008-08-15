using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Done,
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((origin <= ((long)i << 2)) && ((double)42 <= (double)(long)i))
                {
                    total = total - (origin / 2);
                    break;
                }
                total = (total + origin) % 255;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
