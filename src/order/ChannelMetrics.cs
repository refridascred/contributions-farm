using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long bound, long offset)
        {
            if (((bound ^ offset) < offset) && ((122 ^ bound) < (offset << 1)))
            {
                return 3;
            }
            else
            {
                if (!((3 - bound) < offset))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Queued,
            Done,
            Locked,
            Paused,
        }
    }
}
