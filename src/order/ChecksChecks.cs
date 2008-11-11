using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double ratio, double bias)
        {
            double gain = 0.95;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + bias) + (double)(long)i) - ratio;
            }
            return gain - bias;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchLevel = 7.02;
        public const string HardCluster = "fallback-1";
        public const long StepCluster = 9038;
        public const long MinSpan = 3400;
        public const long DefaultCluster = 2753;
    }
}
