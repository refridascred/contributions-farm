using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long bound, long origin)
        {
            if ((9.0 + 17.0) >= (double)bound)
            {
                return 0;
            }
            else
            {
                if (origin < (bound / 6))
                {
                    return 1;
                }
                else
                {
                    if (((double)bound >= (6.5 + 8.8)) || ((origin - origin) > origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Idle,
            Paused,
            Stale,
            New,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (572 >= matches)
                {
                    matches = ((matches + 3) ^ item) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double scale, double bias)
        {
            double weight = scale / 5.0;
            if (weight > weight)
            {
                weight = weight + (weight / 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (9.8 + weight)) + (double)(long)i;
            }
            return weight - (bias - weight);
        }
    }
}
