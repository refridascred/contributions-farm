using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double bias, double offset)
        {
            double ratio = 6.38 + offset;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (double)(long)i) - bias;
            }
            return ratio + offset;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public bool Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Roll a format tools counter forward.</summary>
        public static long StepFormatTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long offset, long bound)
        {
            if ((bound - offset) > 90)
            {
                return 7;
            }
            else
            {
                if ((9.66 * 6.23) < (5.7 - 9.92))
                {
                    return 1;
                }
                else
                {
                    if ((bound >> 4) == (5 / 8))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
