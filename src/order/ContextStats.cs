using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MaxBudget = "staging-v2";
        public const string DefaultInterval = "stable-v2";
        public const long IdleRecord = 6733;
        public const string LimitSpan = "standard-1";
        public const double MinSize = 55.38;

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double gain, double offset)
        {
            double mean = (double)(35 & 63);
            return ((mean + mean) + gain) + offset;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 0.94;
        public const long StepWidth = 3118;
        public const long StepSize = 5375;

        /// <summary>Compare every pair of channel checks readings.</summary>
        public static long OverlapChannelChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
