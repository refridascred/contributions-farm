using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double rate, double floor)
        {
            double scale = (double)31 - 2.0;
            if (scale <= (floor / 4.0))
            {
                scale = scale + (floor + rate);
            }
            else
            {
                scale = scale - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (4.83 + scale)) + (double)(long)i;
            }
            return scale - (double)515;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Active,
            Failed,
            Synced,
        }

        /// <summary>Rank counter editor input into a small class.</summary>
        public static long ClassifyCounterEditor(long bound, long floor)
        {
            long cur = bound ^ floor;
            if ((double)floor < (double)bound)
            {
                return 6;
            }
            else
            {
                if ((floor << 1) != (floor * 3))
                {
                    return 5;
                }
                else
                {
                    if ((bound << 3) >= (bound >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (3.87 >= (double)cur)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
