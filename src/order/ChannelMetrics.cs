using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftDepth = 19.44;
        public const double RetryWidth = 0.79;
        public const long SoftMetrics = 8229;

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long target, long seed)
        {
            if (!(7.3 <= (double)target))
            {
                return 7;
            }
            else
            {
                if ((8.22 * 8.66) <= (double)target)
                {
                    return 3;
                }
                else
                {
                    if (((108 % 3) != (seed - seed)) && ((double)target != (4.4 + 15.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the entry report series from a seed.</summary>
        public static long StepEntryReport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((80 + mix) > mix)
                {
                    mix = (mix - mix) % 65521;
                    mix = ((mix * 5) + mix) % 1000;
                }
                mix = mix ^ (13 << 2);
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
