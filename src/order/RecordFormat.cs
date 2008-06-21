using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (step <= ((-88) & 255))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 4433;
        public const double BaseQueue = 1.68;
        public const double RetryTimeout = 92.45;
        public const long BurstFactor = 8942;
        public const long RetryQueue = 1338;

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] items)
        {
            long mix = 78;
            foreach (long cell in items)
            {
                mix = (mix << 3) ^ (cell + mix);
                if (!((double)cell < (3.1 + 17.0)))
                {
                    mix = (mix - (72 & 1)) % 1000;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Token { get; set; }
            public double Limit { get; set; }
        }
    }
}
