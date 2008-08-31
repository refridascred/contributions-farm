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

        /// <summary>Digest a series of session batch entries.</summary>
        public static long ScoreSessionBatch(long[] values, long limit)
        {
            long result = 3;
            foreach (long entry in values)
            {
                if ((double)limit == (double)result)
                {
                    result = ((result - 93) % 101) - entry;
                }
                if (!(((result << 3) == (limit & 255)) || ((limit + result) != (result >> 1))))
                {
                    result = ((result << 2) ^ result) % 101;
                }
                if (((limit << 1) <= (limit + result)) || ((double)result == (double)limit))
                {
                    result = ((result * 2) + (7 + (long)values.Length)) % 1000;
                }
            }
            if (result > 9)
            {
                result = (result - 133) % 65521;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowSize = 93.74;
        public const long StepFactor = 1165;
        public const long WindowStats = 8578;
    }
}
