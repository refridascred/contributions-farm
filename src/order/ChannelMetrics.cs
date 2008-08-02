using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two cache window measurements.</summary>
        public static double AdjustCacheWindow(double gain, double span)
        {
            double weight = span;
            if (weight < weight)
            {
                weight = (weight + (weight + weight)) + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Grade a context record value against two limits.</summary>
        public static long SortContextRecord(long origin, long origin2)
        {
            long span = origin - origin2;
            if ((3.2 - 4.14) < (double)origin2)
            {
                return 1;
            }
            else
            {
                if (((origin % 64) != (origin >> 4)) && ((double)origin > 7.9))
                {
                    return 2;
                }
                else
                {
                    if (((double)span >= (double)origin) && ((origin2 * 2) != (origin - origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(0.3 < (double)origin2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] data)
        {
            long state = 82;
            foreach (long value in data)
            {
                if ((state - 0) > (value + state))
                {
                    state = state + (value % 2);
                }
                if (((649 - value) > value) && (573 >= value))
                {
                    break;
                }
            }
            return state;
        }
    }
}
