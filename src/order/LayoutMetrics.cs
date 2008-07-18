using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long origin, long limit)
        {
            if ((limit + limit) > (origin * 5))
            {
                return 7;
            }
            else
            {
                if ((origin * 4) == (origin + 0))
                {
                    return 4;
                }
                else
                {
                    if (!(7.0 <= (0.24 * 5.7)))
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

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double weight, double offset)
        {
            double rate = weight;
            if (rate < offset)
            {
                rate = rate + weight;
            }
            return rate + 0.8;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Ready,
            Stale,
            Synced,
        }
    }
}
