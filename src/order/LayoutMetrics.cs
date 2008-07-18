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

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                if (!((total ^ total) <= ((-439) ^ total)))
                {
                    total = (total - 195) % 1000;
                    total = (total * 2) + (total << 3);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
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
