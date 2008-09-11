using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item ^ 313) <= (hits ^ item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the checks batch entries that pass the check.</summary>
        public static long CountChecksBatchGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((value * 2) > (value >> 2)) || ((value & 3) != (630 + target)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowInterval = 5726;
        public const long BaseLayout = 353;
        public const double MinSize = 23.38;
        public const long CacheLayout = 6662;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
