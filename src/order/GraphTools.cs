using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double weight, double floor)
        {
            double mean = weight;
            if (mean < weight)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + (mean / 4.0);
            }
            return mean + (floor / 4.0);
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long offset, long floor)
        {
            long next = offset - floor;
            if ((0.1 / 2.0) > (double)next)
            {
                return 3;
            }
            else
            {
                if (((33 * 5) >= next) && ((next + 24) <= (next + 46)))
                {
                    return 7;
                }
                else
                {
                    if ((floor + floor) > (offset & 31))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
