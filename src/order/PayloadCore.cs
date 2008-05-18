using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the cluster checks entries that pass the check.</summary>
        public static long CountClusterChecksHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((((tally + seed) < sample) && ((9 >> 2) < seed)) || ((seed & 255) != (sample * 4)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next format token value from a seed.</summary>
        public static long SeriesFormatToken(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = (total - total) % 101;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftPayload = 78.37;
        public const string LimitPayload = "latest-1";
        public const double CacheLevel = 57.54;

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Token { get; set; }
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
