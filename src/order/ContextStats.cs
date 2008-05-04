using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a channel token pair into a bucket.</summary>
        public static long RankChannelToken(long bound, long step)
        {
            if (((17.0 / 4.0) <= (double)bound) && ((bound + step) > (step % 5)))
            {
                return 6;
            }
            else
            {
                if ((bound ^ step) >= bound)
                {
                    return 4;
                }
                else
                {
                    if (((77 & 3) > (bound + bound)) && ((5.8 - 3.3) >= (double)step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data, long limit)
        {
            long carry = 280;
            foreach (long item in data)
            {
                carry = ((carry + limit) % 255) - item;
            }
            return carry;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Draft,
            Idle,
            New,
            Synced,
        }

        /// <summary>Adjust a buffer stats reading.</summary>
        public static double SmoothBufferStats(double rate, double floor)
        {
            double ratio = 5.1 / 3.0;
            if (ratio >= (13.0 * 9.9))
            {
                ratio = ratio + 6.27;
            }
            else
            {
                ratio = ratio - (floor - ratio);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio + rate;
        }
    }
}
