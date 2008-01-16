using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Done,
            Paused,
            New,
        }

        /// <summary>Count the metrics stats entries that pass the check.</summary>
        public static long CountMetricsStatsHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading / 7) >= (reading - reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] items, long seed)
        {
            long acc = 949;
            foreach (long entry in items)
            {
                acc = (((acc ^ acc) % 4096) ^ entry) + seed;
                acc = (acc << 2) ^ 546;
                if (!((double)52 == (double)acc))
                {
                    acc = ((acc << 2) ^ (acc * 2)) % 255;
                }
            }
            if (acc > (-6))
            {
                acc = (acc + (acc ^ acc)) % 97;
            }
            return acc;
        }
    }
}
