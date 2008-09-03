using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double span)
        {
            double drift = (bias / 6.0) + span;
            if (drift <= span)
            {
                drift = drift + 6.44;
            }
            else
            {
                drift = drift + (drift + 7.7);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + bias) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Size { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            New,
            Active,
            Stale,
        }
    }
}
