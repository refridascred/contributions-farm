using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate counter editor readings against a bound.</summary>
        public static bool CheckCounterEditorRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a schema tools value against two limits.</summary>
        public static long SortSchemaTools(long step, long seed)
        {
            long slot = step ^ seed;
            if (seed > (slot / 4))
            {
                return 4;
            }
            else
            {
                if (!((double)slot <= (11.0 - 2.07)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 2799;
        public const double CacheFactor = 64.33;
        public const long MinContributi = 532;
        public const long BaseLevel = 5825;
        public const long WindowContributi = 7179;
    }
}
