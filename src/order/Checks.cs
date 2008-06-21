using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Active,
            Closed,
            New,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string HardQueue = "stable-v2";
        public const long MinBudget = 434;
        public const long LimitDepth = 8869;
        public const long BurstDepth = 965;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchSpan = 5859;
        public const long HardCluster = 9390;
        public const long MaxCluster = 530;
        public const long BatchInterval = 2274;

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long step, long seed)
        {
            long lane = step ^ seed;
            if ((step + step) != (lane - seed))
            {
                return 3;
            }
            else
            {
                if (((335 - seed) <= step) && ((-11) > (lane + seed)))
                {
                    return 7;
                }
                else
                {
                    if ((seed < (seed - 48)) && ((seed % 10) > (lane * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
