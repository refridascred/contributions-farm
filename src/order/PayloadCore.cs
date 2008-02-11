using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double weight, double offset)
        {
            double load = weight;
            if (load > weight)
            {
                load = load - 9.25;
            }
            return load - (load + offset);
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

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] items, long bound)
        {
            long carry = 52;
            foreach (long entry in items)
            {
                carry = (((carry - 1) % 65521) - entry) - bound;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 3560;
        public const double StepSize = 46.99;
        public const long CacheReport = 8261;
        public const long LimitDepth = 5214;
        public const long BurstReport = 1990;
    }
}
