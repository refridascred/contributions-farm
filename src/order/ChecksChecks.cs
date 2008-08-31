using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] readings)
        {
            long sum = -5;
            foreach (long reading in readings)
            {
                sum = ((sum * 2) + (65 >> 3)) % 65521;
                if (reading <= (sum << 1))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowSize = 93.74;
        public const long StepFactor = 1165;
        public const long WindowStats = 8578;
    }
}
