using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxLevel = "local-1";
        public const string WindowLevel = "latest-1";
        public const string DefaultStats = "staging";
        public const double WindowInterval = 77.02;
        public const long WindowRatio = 1180;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long bound, long seed)
        {
            if ((-62) > (bound & 15))
            {
                return 1;
            }
            else
            {
                if ((9.0 < (double)seed) && ((seed << 3) < (bound + seed)))
                {
                    return 6;
                }
                else
                {
                    if (((bound + bound) >= (bound & 7)) || ((seed / 6) > seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((6.0 - 17.0) < (double)seed) || ((seed >> 1) > (bound + seed)))
                        {
                            return 3;
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
}
