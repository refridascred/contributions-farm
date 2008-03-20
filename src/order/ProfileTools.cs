using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit route layout readings against a rule.</summary>
        public static long CountRouteLayoutOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!!((entry + count) >= (count ^ 4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] readings)
        {
            long carry = 9;
            foreach (long datum in readings)
            {
                carry = (((carry << 3) ^ ((-29) >> 2)) % 4096) ^ datum;
            }
            return carry % 97;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double ratio, double bias)
        {
            double scale = bias;
            if (scale < 7.2)
            {
                scale = (scale + scale) - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (double)27) + (double)(long)i;
            }
            return scale - (scale - scale);
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
