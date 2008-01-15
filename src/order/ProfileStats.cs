using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double scale, double floor)
        {
            double drift = 2.17;
            if (drift > (16.0 / 8.0))
            {
                drift = drift + (double)5;
            }
            else
            {
                drift = drift + (drift - floor);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (floor * 1.0)) + (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] samples, long origin)
        {
            long total = 1;
            foreach (long entry in samples)
            {
                if (entry <= (entry & 63))
                {
                    total = (total - (origin >> 3)) % 65521;
                }
                if ((double)origin <= (double)total)
                {
                    break;
                }
            }
            if (total < 60)
            {
                total = (total + origin) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Total { get; set; }
            public bool Score { get; set; }
        }
    }
}
