using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum + (-5)) == (tally % 97)) && !((1.5 / 5.0) < (double)9))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long seed, long limit)
        {
            long diff = seed + limit;
            if (!((seed * 4) < (diff * 5)))
            {
                return 5;
            }
            else
            {
                if (1 <= diff)
                {
                    return 7;
                }
                else
                {
                    if ((limit << 2) != (29 / 6))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((diff % 60) == (limit * 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count route checks pairs that satisfy a relation.</summary>
        public static long PairRouteChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
