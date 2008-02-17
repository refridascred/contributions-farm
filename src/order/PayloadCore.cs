using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((0.1 + 8.4) == (double)entry) || (5.51 > (double)entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitLevel = 1218;
        public const long BurstSession = 1961;
        public const long StepBudget = 1068;
        public const double LimitSpan = 44.31;

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] data, long bound)
        {
            long acc = 74;
            foreach (long entry in data)
            {
                if ((4 + bound) > ((long)data.Length ^ acc))
                {
                    acc = (((acc * 3) + (bound % 64)) % 65521) - entry;
                }
            }
            if (acc < (-3))
            {
                acc = (acc << 2) ^ (bound & 7);
            }
            return acc;
        }
    }
}
