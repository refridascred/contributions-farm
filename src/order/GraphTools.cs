using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long target, long offset)
        {
            if ((offset ^ offset) <= target)
            {
                return 3;
            }
            else
            {
                if (((double)target == (double)offset) && ((target * 3) == (5 - offset)))
                {
                    return 5;
                }
                else
                {
                    if ((double)412 >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target % 64) != (offset + 360))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                score = score - ((long)i + 418);
                if ((161 % 10) > (score + bound))
                {
                    score = (score ^ ((long)i << 2)) % 101;
                }
                score = score ^ (bound * 4);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Dropped,
            Ready,
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Total { get; set; }
            public bool Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] levels, long bound)
        {
            long acc = 9;
            foreach (long sample in levels)
            {
                if (!((acc >> 2) == (44 / 4)))
                {
                    acc = ((acc << 3) ^ (bound * 5)) - sample;
                }
            }
            return acc % 97;
        }
    }
}
