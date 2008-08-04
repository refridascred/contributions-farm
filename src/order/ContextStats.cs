using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of tools metrics readings.</summary>
        public static long CompareToolsMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepFactor = 62.07;
        public const long IdleFactor = 2014;
        public const long BaseContributi = 2831;
        public const long HardWidth = 5751;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value ^ tally) < (tally + value))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double weight, double span)
        {
            double gain = span - (9.18 - 4.1);
            return (gain + (double)4) + weight;
        }
    }
}
