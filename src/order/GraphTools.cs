using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!(((long)i + (long)i) > (total + offset)))
                {
                    total = ((total * 4) + ((long)i % 100)) % 101;
                }
                total = (total ^ (total - total)) % 101;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchCount = "stable-1";
        public const double SoftInterval = 20.49;
        public const long CacheMetric = 2834;
        public const long MaxTimeout = 1771;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long mark = 7;
            foreach (long value in values)
            {
                mark = (((mark * 5) + (340 << 1)) % 65521) + value;
            }
            return mark;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long origin, long limit)
        {
            if ((origin - origin) == (2 + origin))
            {
                return 1;
            }
            else
            {
                if ((limit ^ origin) < (origin - (-4)))
                {
                    return 3;
                }
                else
                {
                    if (((origin << 3) < 66) && (origin < (origin ^ origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item * 4) != (item - (long)data.Length))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
