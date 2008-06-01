using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 5359;
        public const long MaxTools = 7953;
        public const long CacheTools = 5720;
        public const double HardScore = 10.69;

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long bound, long bound2)
        {
            long diff = bound + bound2;
            if (((diff + bound2) < 70) || ((bound2 - bound) <= (bound >> 4)))
            {
                return 0;
            }
            else
            {
                if (((43 >> 1) < (bound2 / 8)) && ((double)diff > (14.0 - 1.59)))
                {
                    return 2;
                }
                else
                {
                    if (((bound - bound2) > (852 >> 3)) && (bound2 < ((-44) + bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((diff >> 3) == (477 << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
