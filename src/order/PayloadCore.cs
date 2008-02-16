using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long limit, long origin)
        {
            long span = limit - origin;
            if (!((0.88 - 8.9) > (double)origin))
            {
                return 1;
            }
            else
            {
                if (((limit + span) != (31 - limit)) || ((15.0 - 1.6) > (double)span))
                {
                    return 5;
                }
                else
                {
                    if ((span + limit) >= (span >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit % 12) < limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double ratio, double bias)
        {
            double mean = ratio / 5.0;
            if (mean >= ratio)
            {
                mean = mean - (mean / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (bias / 3.0)) + (double)(long)i;
            }
            return mean + ratio;
        }
    }
}
