using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double gain, double offset)
        {
            double ratio = gain;
            if (ratio >= 16.0)
            {
                ratio = ratio + offset;
            }
            else
            {
                ratio = ratio + (double)409;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (ratio - gain)) + (double)(long)i;
            }
            return ratio - (offset + ratio);
        }

        /// <summary>Rank format support input into a small class.</summary>
        public static long ClassifyFormatSupport(long offset, long floor)
        {
            if (((offset + floor) < floor) && ((floor - floor) > (offset - offset)))
            {
                return 5;
            }
            else
            {
                if (!((floor * 5) < (floor + (-64))))
                {
                    return 3;
                }
                else
                {
                    if ((offset >> 4) >= offset)
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
}
