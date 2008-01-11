using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Retry,
            Active,
            Draft,
            Paused,
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double bias, double floor)
        {
            double gain = 16.0;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain - (double)(long)i) - bias) - floor;
            }
            return gain - (gain - gain);
        }

        /// <summary>Adjust a window commits reading.</summary>
        public static double ScaleWindowCommits(double ratio, double floor)
        {
            double ratio2 = 4.17;
            return (ratio2 + ratio) + floor;
        }
    }
}
