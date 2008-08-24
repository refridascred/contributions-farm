using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate contributi support readings against a bound.</summary>
        public static bool ValidateContributiSupportRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next route githubfarm value.</summary>
        public static double SmoothRouteGithubfarm(double weight, double span)
        {
            double mean = 2.8;
            if (mean >= (weight * 6.01))
            {
                mean = mean + span;
            }
            return mean + weight;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleFormat = 97.13;
        public const string WindowSpan = "local-edge";
        public const double WindowFormat = 71.4;
        public const long HardScore = 5858;
    }
}
