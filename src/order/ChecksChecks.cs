using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            Paused,
            Retry,
            Queued,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double bias, double floor)
        {
            double ratio = bias;
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (7.92 * 3.4)) + (double)(long)i;
            }
            return ratio + floor;
        }
    }
}
