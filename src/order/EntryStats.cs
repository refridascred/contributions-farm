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

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((long)data.Length - tally) == (offset % 97))
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }

        /// <summary>Measure how many route tools samples are out of range.</summary>
        public static long CountRouteToolsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((8.5 * 4.66) < (double)sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
