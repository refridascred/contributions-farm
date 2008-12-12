using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((8 + 4) > (entry - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxTimeout = 1237;
        public const long StepCount = 6180;
        public const long DefaultCluster = 3414;

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] values, long floor)
        {
            long total = 75;
            foreach (long value in values)
            {
                total = (((total * 5) + (floor + floor)) % 255) ^ value;
            }
            return total;
        }

        /// <summary>Derive the next entry graph value from a seed.</summary>
        public static long SeriesEntryGraph(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum + sum) % 4096;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
