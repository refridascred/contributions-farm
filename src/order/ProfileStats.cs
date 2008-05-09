using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long offset)
        {
            if ((target - 54) > offset)
            {
                return 5;
            }
            else
            {
                if ((7.6 + 2.0) >= (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((offset >= (target & 255)) && ((target >> 1) > (target + offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a format account pair into a bucket.</summary>
        public static long GradeFormatAccount(long origin, long floor)
        {
            long edge = origin ^ floor;
            if ((double)origin < 5.73)
            {
                return 6;
            }
            else
            {
                if (((74 ^ 50) == (floor + origin)) || ((double)floor < (1.8 + 4.6)))
                {
                    return 7;
                }
                else
                {
                    if ((4.98 + 7.19) <= (double)edge)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Token { get; set; }
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double gain, double bias)
        {
            double weight = (double)(3 << 2);
            if (weight > gain)
            {
                weight = (weight - (double)8) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + gain;
        }
    }
}
