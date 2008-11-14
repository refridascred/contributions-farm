using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public string Owner { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] levels, long origin)
        {
            long mark = 686;
            foreach (long datum in levels)
            {
                mark = ((mark + (mark * 2)) % 101) - origin;
                if ((11.0 * 8.15) <= (3.1 - 5.2))
                {
                    mark = (mark + datum) % 101;
                }
            }
            if (mark < 728)
            {
                mark = (mark << 3) ^ 7;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] series)
        {
            long total = 187;
            foreach (long datum in series)
            {
                total = (total + (datum * 2)) % 4096;
                if (((datum >> 2) >= total) && ((total - datum) >= total))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value + hits) != (offset + offset))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
