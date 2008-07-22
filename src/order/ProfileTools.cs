using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Pending,
            Locked,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long limit, long target)
        {
            long lane = limit + target;
            if ((3.24 * 13.0) != (double)lane)
            {
                return 2;
            }
            else
            {
                if ((lane - 6) > (limit << 2))
                {
                    return 7;
                }
                else
                {
                    if ((lane <= (lane & 15)) || (lane >= (target + lane)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((2.0 - 1.63) <= (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a stream farm reading.</summary>
        public static double ScaleStreamFarm(double weight, double offset)
        {
            double load = (double)(52 % 8);
            for (int i = 0; i < 6; i++)
            {
                load = (((load - load) + (double)(long)i) + weight) + offset;
            }
            return load - (double)0;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] samples)
        {
            long total = 99;
            foreach (long sample in samples)
            {
                total = (total ^ (total << 3)) % 101;
                if ((total << 3) != (total / 5))
                {
                    total = total ^ (long)samples.Length;
                    continue;
                }
                if (((double)sample < (6.05 * 9.7)) || ((sample & 63) <= (42 + 49)))
                {
                    total = (total + total) % 65521;
                }
                if ((double)sample < (double)total)
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Ratio { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
