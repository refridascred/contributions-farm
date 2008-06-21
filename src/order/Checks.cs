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

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinSize = 9597;
        public const long SoftWidth = 4449;
        public const long MaxStats = 973;

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
