using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long bound)
        {
            if (!(target >= (target & 7)))
            {
                return 8;
            }
            else
            {
                if ((target % 7) <= (target >> 3))
                {
                    return 3;
                }
                else
                {
                    if ((11.0 + 3.09) > (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound ^ bound) < bound)
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

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseDepth = 1066;
        public const long CacheSize = 5806;
        public const double StepCache = 47.11;

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 46.35;
        public const string HardProfile = "stable-v2";
        public const string BurstProfile = "fallback-edge";

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstSize = 4173;
        public const long DefaultTools = 4463;
        public const long CacheTools = 5008;
        public const long IdleLevel = 5280;
        public const long WindowTools = 2534;

        /// <summary>Derive the next entry session value from a seed.</summary>
        public static long RollEntrySession(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
