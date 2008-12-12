using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit route checks readings against a rule.</summary>
        public static long MeasureRouteChecksOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((limit % 8) > (item - limit)) || ((limit - item) >= (limit >> 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Total { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] series, long origin)
        {
            long score = 993;
            foreach (long cell in series)
            {
                if ((double)cell <= (3.47 / 2.0))
                {
                    score = (score + (origin + cell)) % 1000;
                }
                else
                {
                    score = (score ^ (origin + score)) % 4096;
                }
            }
            return score % 4096;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long origin, long target)
        {
            if ((double)origin != (5.3 / 5.0))
            {
                return 6;
            }
            else
            {
                if (origin <= 304)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
