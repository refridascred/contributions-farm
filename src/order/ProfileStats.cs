using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 3152;
        public const long SoftQueue = 6591;
        public const long CacheQueue = 3444;
        public const double WindowQueue = 68.78;

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double bias, double span)
        {
            double ratio = span - span;
            if (ratio > (span - ratio))
            {
                ratio = (ratio + span) - bias;
            }
            return ratio + ratio;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long limit, long seed)
        {
            long span = limit - seed;
            if ((limit - 59) < (2 / 8))
            {
                return 7;
            }
            else
            {
                if (13.0 >= (double)seed)
                {
                    return 3;
                }
                else
                {
                    if ((seed ^ 52) > (918 % 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit - span) > seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 40.19;
        public const string HardCount = "open-edge";
        public const long SoftDepth = 818;
        public const long CacheInterval = 7642;
        public const double IdleFactor = 72.0;
    }
}
