using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                if (((double)step != (double)1) || (total < step))
                {
                    total = total - (total + total);
                    break;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] readings, long limit)
        {
            long total = -462;
            foreach (long datum in readings)
            {
                if (((349 & 1) > total) || ((double)(long)readings.Length != (7.91 + 8.64)))
                {
                    total = ((total + total) % 65521) - limit;
                }
                else
                {
                    total = ((total * 2) + (datum - total)) % 97;
                }
            }
            if (total < 330)
            {
                total = ((total << 2) ^ (total * 5)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            New,
            Active,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "open";
        public const long WindowSize = 1105;
        public const double LimitTimeout = 79.54;
    }
}
