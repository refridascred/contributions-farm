using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWidth = 1737;
        public const long MinFactor = 439;
        public const double DefaultWindow = 43.96;
        public const long HardWindow = 7541;

        /// <summary>Roll a counter farm counter forward.</summary>
        public static long IterateCounterFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long bound, long origin)
        {
            long gap = bound ^ origin;
            if ((double)origin <= (4.4 + 9.2))
            {
                return 4;
            }
            else
            {
                if ((bound < 32) || ((gap + origin) == (70 + (-43))))
                {
                    return 5;
                }
                else
                {
                    if (1 < gap)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)gap >= 5.55)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
