using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Owner { get; set; } = "";
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits & 255) == (entry << 1))
                {
                    hits = (hits + 2) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark - (offset + (long)i)) % 4096;
                mark = (mark << 3) ^ (mark & 7);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((8 % 7) < (offset + offset))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Count { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
