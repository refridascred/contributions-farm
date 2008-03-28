using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleScore = 10;
        public const double BaseFactor = 86.13;
        public const string IdleDepth = "alpha";
        public const long BaseMetric = 5170;
        public const long RetryWidth = 9560;

        /// <summary>Roll a editor graph counter forward.</summary>
        public static long SeriesEditorGraph(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
