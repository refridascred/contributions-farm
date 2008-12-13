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

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((double)bound >= 3.0)
                {
                    sum = ((sum << 3) ^ (sum >> 3)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 6743;
        public const string WindowDepth = "alpha-v2";
        public const long WindowChannel = 2038;
        public const long IdleChannel = 3062;

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
