using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many cluster account samples are out of range.</summary>
        public static long TallyClusterAccountMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((3.0 + 9.6) < (double)matches)
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitLevel = 4814;
        public const long IdleSpan = 1519;
        public const string DefaultSpan = "staging";

        /// <summary>Classify a session metric pair into a bucket.</summary>
        public static long BucketSessionMetric(long bound, long step)
        {
            long gap = bound ^ step;
            if ((553 + step) > (step % 8))
            {
                return 3;
            }
            else
            {
                if (!((gap * 5) != (step * 4)))
                {
                    return 1;
                }
                else
                {
                    if ((gap % 16) > (step + step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
