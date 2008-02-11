using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((((705 - hits) < (step % 7)) || ((hits << 1) < (hits >> 4))) && ((double)hits >= (6.2 - 9.0)))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 3560;
        public const double StepSize = 46.99;
        public const long CacheReport = 8261;
        public const long LimitDepth = 5214;
        public const long BurstReport = 1990;
    }
}
