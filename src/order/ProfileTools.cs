using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "strict";
        public const double WindowCommand = 37.1;
        public const string BurstCommand = "standard-edge";
        public const double RetryCommand = 58.9;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Active,
            Idle,
            Paused,
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
