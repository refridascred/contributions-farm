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

        /// <summary>Compare every pair of layout graph readings.</summary>
        public static long MatchLayoutGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
