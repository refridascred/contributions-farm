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

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long floor, long floor2)
        {
            if ((floor2 - 82) == (floor + 800))
            {
                return 4;
            }
            else
            {
                if ((floor2 % 16) <= (floor + floor2))
                {
                    return 8;
                }
                else
                {
                    if ((floor - floor) != (floor2 + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor >= (floor - floor2))
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

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] samples)
        {
            long total = 4;
            foreach (long sample in samples)
            {
                if (sample < (total + sample))
                {
                    total = total + (total << 1);
                }
            }
            if (total > (-533))
            {
                total = (total << 3) ^ total;
            }
            return total;
        }
    }
}
