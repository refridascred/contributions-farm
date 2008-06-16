using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double ratio, double bias)
        {
            double mean = ratio;
            if (mean > mean)
            {
                mean = (mean + (double)83) - bias;
            }
            return mean + (ratio + ratio);
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long floor, long offset)
        {
            if (!((2 + floor) == (floor - offset)))
            {
                return 1;
            }
            else
            {
                if (((offset << 1) < floor) || ((double)floor >= (8.5 - 8.46)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Match up queue batches samples.</summary>
        public static long OverlapQueueBatchesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings, long origin)
        {
            long mix = 498;
            foreach (long item in readings)
            {
                if (mix >= (origin - 0))
                {
                    mix = (mix - 52) + item;
                }
                if ((origin - origin) >= mix)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long step, long origin)
        {
            long bound = step - origin;
            if (((12.0 * 3.28) <= (double)origin) && ((step % 97) <= step))
            {
                return 6;
            }
            else
            {
                if ((bound << 3) <= origin)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
