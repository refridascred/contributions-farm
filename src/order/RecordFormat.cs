using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!((((-446) + 966) >= (state + limit)) || (state < limit)))
                {
                    state = state - limit;
                }
                state = state - (limit / 3);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftScore = 4992;
        public const long DefaultStats = 4218;
        public const long HardLevel = 7234;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 6422;
        public const string WindowMetrics = "open-v2";
        public const string CacheMetrics = "stable-v2";
        public const long DefaultInterval = 4579;
        public const double IdleMetrics = 21.17;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a cluster record reading by value.</summary>
        public static long FindClusterRecordIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
