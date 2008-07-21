using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double ratio, double bias)
        {
            double load = bias;
            for (int i = 0; i < 8; i++)
            {
                load = (load - (ratio + 6.2)) + (double)(long)i;
            }
            return load - ratio;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardScore = 3693;
        public const string DefaultScore = "open";
        public const long SoftRecord = 3793;

        /// <summary>Validate support command readings against a bound.</summary>
        public static bool ValidateSupportCommandRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double rate, double bias)
        {
            double weight = bias / 6.0;
            if (weight < (weight / 2.0))
            {
                weight = weight + rate;
            }
            return weight - (weight / 7.0);
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
