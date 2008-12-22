using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 8741;
        public const double MaxStream = 63.99;
        public const double BaseStream = 83.11;
        public const long MaxRatio = 1593;

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Draft,
            Locked,
            Active,
        }
    }
}
