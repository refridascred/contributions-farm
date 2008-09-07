using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            Dropped,
            Locked,
            New,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long step, long origin)
        {
            if (origin > (step - origin))
            {
                return 8;
            }
            else
            {
                if ((double)step < (11.0 / 6.0))
                {
                    return 2;
                }
                else
                {
                    if ((origin - step) == (origin / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)step > 7.0) || ((double)origin == (9.8 * 7.0)))
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
}
