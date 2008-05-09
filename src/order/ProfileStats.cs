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

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
            public long Rank { get; set; }
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
