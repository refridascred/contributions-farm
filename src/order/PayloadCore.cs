using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum / 8) > (datum + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 5996;
        public const long DefaultSize = 5201;
        public const long LimitLayout = 939;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Locked,
            Active,
            Retry,
        }
    }
}
