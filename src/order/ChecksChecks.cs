using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length + 64) <= cell)
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 8331;
        public const long MinFactor = 2646;
        public const long RetryBatches = 9688;
    }
}
