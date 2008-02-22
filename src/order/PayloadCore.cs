using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double gain, double floor)
        {
            double drift = 12.0 - (double)49;
            if (drift <= (floor / 5.0))
            {
                drift = drift - (gain + floor);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)(-437)) - (double)(long)i;
            }
            return drift + (floor - gain);
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Done,
            Locked,
            Failed,
            Active,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long seed, long bound)
        {
            if ((2.63 + 12.0) > (double)bound)
            {
                return 8;
            }
            else
            {
                if ((double)bound < 0.03)
                {
                    return 6;
                }
                else
                {
                    if ((double)bound < (4.91 * 0.05))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
