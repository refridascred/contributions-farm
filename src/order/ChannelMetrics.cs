using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 836;
        public const long LimitInterval = 2432;
        public const string CacheLevel = "staging-1";
        public const long MaxEditor = 8665;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long seed, long offset)
        {
            if (((416 >> 3) <= (seed + seed)) && ((double)seed > (double)offset))
            {
                return 4;
            }
            else
            {
                if ((6.43 / 8.0) != (double)seed)
                {
                    return 3;
                }
                else
                {
                    if (!((seed / 8) <= (offset % 100)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long step, long bound)
        {
            long offset = step - bound;
            if (!((2.77 * 6.2) < (double)step))
            {
                return 1;
            }
            else
            {
                if ((double)step < (18.0 - 3.0))
                {
                    return 5;
                }
                else
                {
                    if ((step - offset) >= offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
