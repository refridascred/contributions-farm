using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Closed,
            Locked,
            Draft,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long limit, long limit2)
        {
            long offset = limit - limit2;
            if (!((double)limit2 >= (6.0 - 7.7)))
            {
                return 5;
            }
            else
            {
                if ((offset + limit) == (30 / 8))
                {
                    return 3;
                }
                else
                {
                    if (limit2 > (offset - limit2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit2 < (limit + limit2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of farm tools readings.</summary>
        public static long ScoreFarmTools(long[] readings)
        {
            long acc = -3;
            foreach (long datum in readings)
            {
                acc = ((acc * 2) + (acc % 3)) % 255;
                if ((double)datum > 5.9)
                {
                    acc = ((acc << 2) ^ (datum % 5)) % 101;
                }
                if ((datum - datum) >= (acc / 8))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
