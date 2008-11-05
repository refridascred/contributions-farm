using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Failed,
            Idle,
            Queued,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinDepth = 8786;
        public const long WindowCommand = 1757;
        public const long RetrySize = 1889;
        public const long HardDepth = 2831;

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double ratio, double bias)
        {
            double mean = ratio * 17.0;
            if (mean > 9.5)
            {
                mean = (mean + 4.68) - bias;
            }
            else
            {
                mean = mean - (double)60;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - 10.0;
        }
    }
}
