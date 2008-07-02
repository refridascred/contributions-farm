using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((value ^ 89) < (seen - value)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryFactor = "local-1";
        public const long IdleCount = 6703;
        public const long BurstWidth = 8832;
        public const long CacheFactor = 7019;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] items, long origin)
        {
            long acc = 7;
            foreach (long reading in items)
            {
                if ((1.39 > (double)acc) && ((reading & 63) <= origin))
                {
                    acc = (acc + (reading >> 4)) % 97;
                }
            }
            if (acc < 4)
            {
                acc = acc - (450 << 2);
            }
            return acc;
        }

        /// <summary>Count the record route entries that pass the check.</summary>
        public static long MeasureRecordRouteHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) != (7 % 3))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }
    }
}
