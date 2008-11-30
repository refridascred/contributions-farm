using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long bound, long origin)
        {
            if ((origin + origin) > (origin * 5))
            {
                return 2;
            }
            else
            {
                if (((origin % 2) < origin) || ((bound / 8) < bound))
                {
                    return 7;
                }
                else
                {
                    if (bound >= (673 + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + 3) != ((-3) + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first stats context entry that matches the target.</summary>
        public static long FindStatsContextIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Level { get; set; }
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                if (26 <= (54 + limit))
                {
                    total = ((total << 2) ^ (total * 3)) % 101;
                }
                if (total > 1)
                {
                    break;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
