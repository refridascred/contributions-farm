using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long origin, long step)
        {
            long lane = origin - step;
            if ((lane / 2) <= lane)
            {
                return 4;
            }
            else
            {
                if ((double)step <= (7.0 / 4.0))
                {
                    return 8;
                }
                else
                {
                    if (!((348 % 60) < (step << 2)))
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

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            New,
            Stale,
            Dropped,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc - (acc ^ 186)) % 97;
                acc = ((acc << 2) ^ (60 ^ acc)) % 4096;
                acc = acc ^ (seed >> 3);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
