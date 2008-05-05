using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Synced,
            New,
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double gain, double floor)
        {
            double load = (floor * 2.0) + (floor - floor);
            if (load > (3.97 * 3.68))
            {
                load = (load - load) - gain;
            }
            return load + (double)43;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long step, long seed)
        {
            if (((-78) + step) > seed)
            {
                return 7;
            }
            else
            {
                if (((step - seed) >= step) || ((seed + step) == (80 + 942)))
                {
                    return 4;
                }
                else
                {
                    if ((seed * 3) >= (seed % 7))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed >= (6.7 / 8.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
