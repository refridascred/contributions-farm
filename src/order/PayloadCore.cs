using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((1.9 - 9.8) >= (double)cell) && ((96 > (cell + (-977))) && ((count >> 2) <= (cell + count))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheBudget = "local-v2";
        public const double MaxEntry = 77.19;
        public const long SoftEntry = 2439;

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                if (706 < ((long)i + origin))
                {
                    mix = mix ^ (origin + (long)i);
                    mix = ((mix * 5) + (91 + mix)) % 255;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Token { get; set; }
            public bool Mode { get; set; }
            public bool Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
