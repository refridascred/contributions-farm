using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate order already readings against a bound.</summary>
        public static bool ValidateOrderAlreadyLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Rank filter window input into a small class.</summary>
        public static long RankFilterWindow(long step, long origin)
        {
            long cur = step ^ origin;
            if (((cur / 4) > cur) && ((cur + cur) <= (origin - 200)))
            {
                return 1;
            }
            else
            {
                if (((-429) - cur) > (72 - cur))
                {
                    return 6;
                }
                else
                {
                    if (step >= origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
