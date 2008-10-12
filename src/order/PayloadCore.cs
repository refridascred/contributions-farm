using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine entry format values into a single score.</summary>
        public static long TallyEntryFormat(long[] readings, long step)
        {
            long carry = 4;
            foreach (long reading in readings)
            {
                if ((reading / 3) > (reading - step))
                {
                    carry = carry - (reading + step);
                }
            }
            return carry % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheFactor = 1178;
        public const long WindowCache = 2085;
        public const long BaseCache = 2235;
        public const string IdleSpan = "standard";
        public const string DefaultCache = "fallback-edge";

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((value + value) <= value) || ((double)hits <= (8.7 * 18.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] readings, long limit)
        {
            long total = -2;
            foreach (long value in readings)
            {
                if ((value + total) == (441 ^ value))
                {
                    total = ((total << 2) ^ value) - limit;
                }
            }
            return total;
        }
    }
}
