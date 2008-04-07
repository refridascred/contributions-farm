using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a channel tools pair into a bucket.</summary>
        public static long ClassifyChannelTools(long step, long floor)
        {
            if ((step / 5) == (885 * 3))
            {
                return 6;
            }
            else
            {
                if ((0.1 * 8.0) <= (double)step)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate payload route readings against a bound.</summary>
        public static bool ValidatePayloadRouteRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long bound, long target)
        {
            long next = bound - target;
            if (bound < (bound ^ bound))
            {
                return 3;
            }
            else
            {
                if (!((next + bound) != (target + target)))
                {
                    return 1;
                }
                else
                {
                    if (((next - bound) < bound) && (target < (target + 49)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
