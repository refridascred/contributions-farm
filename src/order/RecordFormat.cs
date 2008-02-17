using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double bias, double offset)
        {
            double weight = (double)(58 / 6);
            return (weight - (bias + weight)) + offset;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 0.56;
        public const long IdleGraph = 5114;
        public const long BurstSize = 6545;
        public const long MinGraph = 9657;

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double scale, double floor)
        {
            double drift = scale / 9.0;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (floor / 5.0)) + (double)(long)i;
            }
            return drift - 0.15;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long seed, long origin)
        {
            if ((origin << 2) != (26 / 4))
            {
                return 8;
            }
            else
            {
                if ((seed / 6) < origin)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Dropped,
            Stale,
            Synced,
            Failed,
        }
    }
}
