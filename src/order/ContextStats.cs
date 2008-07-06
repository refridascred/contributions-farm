using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long origin, long bound)
        {
            if (((-16) + origin) == (978 - bound))
            {
                return 5;
            }
            else
            {
                if ((6.7 + 6.8) > (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double weight, double floor)
        {
            double drift = floor / 6.0;
            if (drift >= drift)
            {
                drift = drift + (floor - floor);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - weight) + (double)(long)i;
            }
            return drift - (weight / 7.0);
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double bias, double span)
        {
            double mean = (double)((-50) % 8);
            if (mean < bias)
            {
                mean = mean - (span / 4.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (span + span)) + (double)(long)i;
            }
            return mean + (span * 2.71);
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
