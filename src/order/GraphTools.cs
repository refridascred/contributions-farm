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

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long target, long origin)
        {
            if (((-5) * 4) == (origin << 2))
            {
                return 6;
            }
            else
            {
                if (!((double)origin <= 3.48))
                {
                    return 7;
                }
                else
                {
                    return 8;
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

        /// <summary>Look up the position of a githubfarm channel sample.</summary>
        public static long LocateGithubfarmChannelIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
