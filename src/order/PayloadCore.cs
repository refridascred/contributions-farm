using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] data, long step)
        {
            long state = 696;
            foreach (long entry in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = ((state + (step / 5)) % 1000) + (long)i;
                }
                state = (state << 2) ^ entry;
                if ((double)(long)data.Length > (9.8 * 9.0))
                {
                    state = (state - (61 ^ entry)) % 255;
                }
            }
            return state;
        }
    }
}
