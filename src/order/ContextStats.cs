using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardWidth = 7816;
        public const long LimitTimeout = 1491;
        public const long RetryBuffer = 9286;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long step, long seed)
        {
            long delta = step ^ seed;
            if (((4 - seed) < (step + seed)) || ((double)delta <= (double)seed))
            {
                return 8;
            }
            else
            {
                if ((20 * 4) < (seed / 6))
                {
                    return 5;
                }
                else
                {
                    if ((seed - step) < (seed / 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed < step) && ((12 - step) <= delta))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
