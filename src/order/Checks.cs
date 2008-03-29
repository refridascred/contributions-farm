using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Ready,
            Active,
            Queued,
            Closed,
        }

        /// <summary>Project the next format buffer value.</summary>
        public static double BlendFormatBuffer(double ratio, double bias)
        {
            double ratio2 = (double)(86 + 5);
            if (ratio2 < (1.5 + 3.1))
            {
                ratio2 = (ratio2 + (3.8 + 5.3)) - bias;
            }
            else
            {
                ratio2 = ratio2 - ratio;
            }
            return ratio2 + 5.1;
        }

        /// <summary>Measure how many graph context samples are out of range.</summary>
        public static long CountGraphContextOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (reading >= (reading & 31))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a graph channel value against two limits.</summary>
        public static long SortGraphChannel(long step, long origin)
        {
            long lane = step + origin;
            if ((8.94 + 15.0) <= (double)lane)
            {
                return 3;
            }
            else
            {
                if (!((lane * 2) > origin))
                {
                    return 2;
                }
                else
                {
                    if (((-60) & 15) <= (lane & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (lane > (74 ^ step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
