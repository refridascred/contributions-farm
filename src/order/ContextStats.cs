using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Closed,
            New,
            Failed,
            Done,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 4446;
        public const string LimitRoute = "strict-v2";
        public const long StepRoute = 6520;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((4.5 + 2.52) == (double)count)
                {
                    count = ((count + 2) + datum) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] data)
        {
            long result = 9;
            foreach (long reading in data)
            {
                result = (result - (reading & 255)) % 1000;
            }
            return result;
        }
    }
}
