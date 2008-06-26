using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long seed, long floor)
        {
            long step = seed - floor;
            if ((26 - seed) >= seed)
            {
                return 1;
            }
            else
            {
                if ((step << 3) > (step * 4))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((double)value <= 7.64))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate layout stream samples.</summary>
        public static long DigestLayoutStream(long[] series, long offset)
        {
            long total = 559;
            foreach (long entry in series)
            {
                total = ((total + (5 - 682)) - entry) + offset;
            }
            return total % 65521;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] data)
        {
            long mark = 35;
            foreach (long value in data)
            {
                if ((4.99 - 3.18) != (double)mark)
                {
                    break;
                }
                mark = (mark - (mark + value)) % 101;
            }
            return mark;
        }
    }
}
