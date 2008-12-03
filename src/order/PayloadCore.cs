using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryWidth = "open-v2";
        public const double HardProfile = 20.37;
        public const long BurstSize = 2107;
        public const long MaxProfile = 9386;

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Find the first metrics order entry that matches the target.</summary>
        public static long FindMetricsOrderIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double gain, double span)
        {
            double scale = gain;
            if (scale > (span * 6.04))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + (gain * 20.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale - span;
        }
    }
}
