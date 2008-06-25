using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitWidth = 1323;
        public const string MaxRecord = "local-1";
        public const long HardRecord = 1937;

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long origin, long seed)
        {
            long edge = origin - seed;
            if (((edge >> 4) == (edge << 2)) && ((edge << 2) != (origin % 3)))
            {
                return 2;
            }
            else
            {
                if ((origin < (origin + 18)) || ((origin / 6) > (seed + origin)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
