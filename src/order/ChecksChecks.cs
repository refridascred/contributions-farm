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

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] values)
        {
            long mix = -473;
            foreach (long value in values)
            {
                mix = mix + (value & 63);
            }
            return mix;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 8331;
        public const long MinFactor = 2646;
        public const long RetryBatches = 9688;
    }
}
