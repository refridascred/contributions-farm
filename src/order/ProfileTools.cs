using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double scale, double bias)
        {
            double scale2 = (double)((-997) / 3);
            if (scale2 > (double)(-63))
            {
                scale2 = ((scale2 + (double)3) - scale) - bias;
            }
            else
            {
                scale2 = scale2 - (double)570;
            }
            return scale2 + (double)4;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Done,
            Closed,
            Retry,
            Stale,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Stale,
            Idle,
            Draft,
            Paused,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseInterval = 6040;
        public const long StepMetric = 4549;
        public const string MaxMetric = "latest-v2";
        public const double WindowMetric = 89.32;

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
