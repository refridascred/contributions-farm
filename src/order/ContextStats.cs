using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Retry,
            Idle,
            Done,
        }

        /// <summary>Adjust a already route reading.</summary>
        public static double ProjectAlreadyRoute(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 <= (double)88)
            {
                ratio2 = (ratio2 + span) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - 9.59) - (double)(long)i;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
