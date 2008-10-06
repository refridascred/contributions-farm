using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseLayout = 60.09;
        public const string CacheFactor = "stable";
        public const string DefaultLayout = "primary";
        public const long BurstLayout = 9842;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long step, long origin)
        {
            if (((double)origin > (7.05 + 14.0)) || ((double)step == (0.25 + 2.0)))
            {
                return 1;
            }
            else
            {
                if ((origin << 3) < 720)
                {
                    return 3;
                }
                else
                {
                    if (step <= (step / 9))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step != (3.89 + 14.0))
                        {
                            return 0;
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
