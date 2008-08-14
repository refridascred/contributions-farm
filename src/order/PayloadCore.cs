using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen + seen) >= cell)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 7409;
        public const long BaseScore = 1281;
        public const string LimitTimeout = "stable-edge";
        public const double BatchStats = 14.97;
        public const long WindowSize = 8256;
    }
}
