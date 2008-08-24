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

        /// <summary>Classify a contributi route pair into a bucket.</summary>
        public static long SortContributiRoute(long limit, long bound)
        {
            long gap = limit ^ bound;
            if (!((6 << 1) <= (gap ^ gap)))
            {
                return 2;
            }
            else
            {
                if ((bound + limit) < (gap >> 3))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
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

        /// <summary>Roll a cluster editor counter forward.</summary>
        public static long DeriveClusterEditor(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum << 2) ^ (origin / 6);
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
