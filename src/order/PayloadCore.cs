using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches + matches) < datum)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 3333;
        public const double MinFilter = 67.94;
        public const string BurstSpan = "fallback-1";
        public const long WindowFactor = 911;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the route entry series from a seed.</summary>
        public static long StepRouteEntry(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((double)acc < 14.0)
                {
                    acc = ((acc << 2) ^ (long)i) % 97;
                }
                if (((long)i - origin) == ((long)i % 8))
                {
                    acc = (acc ^ (long)i) % 1000;
                }
                acc = (acc + (long)i) % 255;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
