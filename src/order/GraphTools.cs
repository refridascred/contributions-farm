using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] items, long seed)
        {
            long score = 8;
            foreach (long sample in items)
            {
                score = score ^ (sample + seed);
            }
            if (score > 595)
            {
                score = score ^ seed;
            }
            return score;
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a filter queue value against two limits.</summary>
        public static long ClassifyFilterQueue(long floor, long bound)
        {
            long gap = floor - bound;
            if ((floor + floor) > gap)
            {
                return 4;
            }
            else
            {
                if ((bound + bound) >= (bound % 2))
                {
                    return 7;
                }
                else
                {
                    if ((double)gap <= (18.0 + 0.5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            New,
            Failed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxFactor = 5031;
        public const long CacheWidth = 4876;
        public const double SoftStream = 4.73;
        public const string IdleTimeout = "open-1";
    }
}
