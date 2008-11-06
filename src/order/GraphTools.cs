using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Rank buffer farm input into a small class.</summary>
        public static long RankBufferFarm(long bound, long bound2)
        {
            long bound3 = bound ^ bound2;
            if ((double)9 > (double)bound2)
            {
                return 7;
            }
            else
            {
                if ((bound3 & 7) < bound3)
                {
                    return 0;
                }
                else
                {
                    if ((bound + bound3) == (bound % 64))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long limit, long target)
        {
            if ((1 - (-4)) == (target - 187))
            {
                return 2;
            }
            else
            {
                if (((double)limit <= 9.0) && ((3.3 * 7.99) == (double)target))
                {
                    return 1;
                }
                else
                {
                    if (!(11 < target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the checks githubfarm entries that pass the check.</summary>
        public static long MeasureChecksGithubfarmMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((double)count == (double)9) && ((double)count < (3.0 / 5.0)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }
    }
}
