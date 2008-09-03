using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two graph editor measurements.</summary>
        public static double SmoothGraphEditor(double weight, double bias)
        {
            double weight2 = (double)(924 - 5);
            if (weight2 <= (double)12)
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 + (bias + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + (weight2 - weight)) + (double)(long)i;
            }
            return weight2 + (weight * 11.0);
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Grade a batch contributi value against two limits.</summary>
        public static long ClassifyBatchContributi(long origin, long origin2)
        {
            if ((8.0 + 8.0) <= (double)origin)
            {
                return 2;
            }
            else
            {
                if ((7.88 * 5.0) > (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((34 <= (origin - (-46))) && ((origin >> 2) == (origin2 - origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin + origin2) < origin2)
                        {
                            return 6;
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
