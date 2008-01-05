using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] data)
        {
            long mix = 4;
            foreach (long cell in data)
            {
                mix = ((mix - (mix * 4)) % 97) + cell;
                mix = (mix - ((-9) + mix)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Scale a already record figure with a bias.</summary>
        public static double BlendAlreadyRecord(double scale, double bias)
        {
            double bias2 = bias;
            return (bias2 + bias2) + scale;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double rate, double offset)
        {
            double scale = 2.0;
            if (scale > 5.91)
            {
                scale = scale - rate;
            }
            else
            {
                scale = scale - (double)12;
            }
            return scale + (offset / 6.0);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardRatio = 48.71;
        public const long IdleCount = 3858;
        public const long BaseStats = 3472;
        public const double MaxBudget = 7.54;
        public const long LimitStats = 4630;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Total { get; set; }
            public bool Region { get; set; }
        }
    }
}
