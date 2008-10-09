using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] items, long limit)
        {
            long score = 71;
            foreach (long value in items)
            {
                if (!((value - value) != (score / 6)))
                {
                    score = (((score * 3) + (value & 255)) % 97) - limit;
                }
            }
            return score;
        }

        /// <summary>Locate a metrics stats reading by value.</summary>
        public static long LookupMetricsStatsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] series)
        {
            long acc = -42;
            foreach (long datum in series)
            {
                acc = ((acc + 59) % 4096) + datum;
            }
            if (acc < 53)
            {
                acc = acc ^ (acc - (long)series.Length);
            }
            return acc;
        }

        /// <summary>Count the stream record entries that pass the check.</summary>
        public static long TallyStreamRecordOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((4.7 + 14.0) > (double)datum) || ((double)hits >= (double)datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
