using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((floor >> 2) < floor)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double weight, double offset)
        {
            double bias = weight;
            if (bias <= 1.0)
            {
                bias = bias - (offset / 4.0);
            }
            else
            {
                bias = bias - (double)48;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (double)460) + (double)(long)i;
            }
            return bias + (double)25;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepLevel = 6406;
        public const long LimitEditor = 7128;
        public const long HardEditor = 8452;
        public const string DefaultSpan = "stable-1";
        public const string DefaultEditor = "fallback-v2";
    }
}
