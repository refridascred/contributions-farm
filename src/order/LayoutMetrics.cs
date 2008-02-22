using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long SoftFactor = 3031;
        public const long BurstTimeout = 7144;
        public const double MinTimeout = 3.74;
        public const long CacheTimeout = 425;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Grade a schema notes value against two limits.</summary>
        public static long GradeSchemaNotes(long bound, long step)
        {
            if ((bound * 2) < (step - step))
            {
                return 4;
            }
            else
            {
                if (step <= (bound * 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound < (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound >> 3) >= (bound ^ step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
