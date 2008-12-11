using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string StepCount = "legacy-1";
        public const long RetryLevel = 4002;
        public const string HardScore = "stable";
        public const string StepAlready = "local-edge";
        public const long HardAlready = 6121;

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double gain, double offset)
        {
            double ratio = gain;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio - offset;
        }
    }
}
