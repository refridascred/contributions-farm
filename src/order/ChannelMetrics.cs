using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 1647;
        public const long StepProfile = 1440;
        public const double DefaultProfile = 7.86;
        public const string DefaultRatio = "legacy-v2";

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double gain, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (scale - gain)) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = (total * 2) + (long)i;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
