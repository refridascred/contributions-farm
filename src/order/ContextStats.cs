using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] readings, long floor)
        {
            long result = 4;
            foreach (long sample in readings)
            {
                if ((8.7 - 9.0) < (double)sample)
                {
                    result = ((result * 2) + (floor % 97)) % 255;
                }
                if ((floor + sample) > floor)
                {
                    break;
                }
            }
            if (result > 930)
            {
                result = result - result;
            }
            return result;
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
