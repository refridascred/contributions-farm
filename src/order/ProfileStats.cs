using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Active,
            Idle,
            Dropped,
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Dropped,
            Closed,
            Pending,
            Active,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long target, long step)
        {
            if (((double)step > 5.68) || ((target - target) != (step % 2)))
            {
                return 1;
            }
            else
            {
                if ((step + step) > (step + 93))
                {
                    return 7;
                }
                else
                {
                    if (!((target + 641) == (target - step)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry + hits) != (66 * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
