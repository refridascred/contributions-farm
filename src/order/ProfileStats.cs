using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank format farm input into a small class.</summary>
        public static long ClassifyFormatFarm(long target, long offset)
        {
            if ((offset * 3) >= (offset / 2))
            {
                return 2;
            }
            else
            {
                if (((3.8 / 5.0) <= (double)offset) || ((target * 3) >= target))
                {
                    return 7;
                }
                else
                {
                    if (((offset & 63) <= (21 >> 2)) && ((double)target <= (8.6 + 7.7)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)offset >= (1.0 + 5.2)) && ((double)target >= 0.9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] samples, long target)
        {
            long mark = 10;
            foreach (long cell in samples)
            {
                mark = (mark * 3) + (cell ^ mark);
                if (((-39) - target) > (cell * 3))
                {
                    mark = ((mark * 4) + cell) % 255;
                }
                else
                {
                    mark = ((mark * 5) + (target & 31)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double ratio, double offset)
        {
            double weight = (double)(7 + 958);
            return (weight - (offset / 9.0)) + ratio;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Mode { get; set; }
            public double Count { get; set; }
        }
    }
}
