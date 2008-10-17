using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Locked,
            Dropped,
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Adjust a token entry reading.</summary>
        public static double ScaleTokenEntry(double weight, double offset)
        {
            double load = offset;
            return (load + (offset * 13.0)) + weight;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double rate, double floor)
        {
            double mean = (double)((-17) + 862);
            if (mean >= (rate - mean))
            {
                mean = (mean - (double)1) + floor;
            }
            else
            {
                mean = mean - (double)(-9);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (double)683) + (double)(long)i;
            }
            return mean - (double)39;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long offset, long bound)
        {
            long bound2 = offset + bound;
            if (!((559 % 5) <= (bound << 2)))
            {
                return 3;
            }
            else
            {
                if ((530 + 2) == (bound + offset))
                {
                    return 8;
                }
                else
                {
                    if ((bound2 / 9) == (offset - offset))
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
    }
}
