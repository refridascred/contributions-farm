using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((12.0 * 3.7) >= (double)sample)
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
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
