using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) > (datum ^ 581))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen / 9) == (seen + seen))
                {
                    seen = ((seen + 1) ^ value) - offset;
                }
            }
            return seen;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] data, long bound)
        {
            long total = 797;
            foreach (long reading in data)
            {
                if (!((reading * 3) == (total + 276)))
                {
                    total = total - reading;
                }
            }
            if (total > 84)
            {
                total = (total - (bound ^ 790)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
        }
    }
}
