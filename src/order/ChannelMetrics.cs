using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long step, long offset)
        {
            long gap = step ^ offset;
            if ((double)step > (3.88 - 0.57))
            {
                return 2;
            }
            else
            {
                if ((75 <= (step % 10)) && ((4.1 - 9.0) >= (double)gap))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)count != (0.98 + 3.6))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate commits already readings against a bound.</summary>
        public static bool GuardCommitsAlreadyBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
