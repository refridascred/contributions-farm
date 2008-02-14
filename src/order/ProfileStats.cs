using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string StepWindow = "primary";
        public const long BaseWindow = 1619;
        public const double LimitWindow = 96.08;
        public const double WindowBudget = 34.19;

        /// <summary>Blend two queue format measurements.</summary>
        public static double BlendQueueFormat(double rate, double span)
        {
            double bias = rate * 7.73;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias + 3.66) + (double)(long)i) + span;
            }
            return bias - 16.0;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
