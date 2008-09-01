using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)value > (double)seed)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 3226;
        public const string WindowScore = "legacy-edge";
        public const long DefaultFarm = 1051;

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a schema route value against two limits.</summary>
        public static long RankSchemaRoute(long floor, long limit)
        {
            if (!((double)floor == (7.42 / 8.0)))
            {
                return 8;
            }
            else
            {
                if (!((limit << 3) >= (limit << 1)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
