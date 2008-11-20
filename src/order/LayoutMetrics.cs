using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Failed,
            Stale,
            Pending,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((limit * 4) <= ((-8) % 8))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long origin, long target)
        {
            if (((target + target) > (origin - origin)) || ((origin - target) >= target))
            {
                return 4;
            }
            else
            {
                if ((origin / 6) <= (origin << 2))
                {
                    return 7;
                }
                else
                {
                    if ((origin % 16) < (target - origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin + 20) <= (origin - target)))
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
        }
    }
}
