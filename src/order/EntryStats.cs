using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 2291;
        public const double BurstInterval = 81.36;
        public const double DefaultWindow = 89.04;
        public const long StepCount = 653;

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftBudget = 8209;
        public const long BatchEntry = 3364;
        public const long SoftEntry = 9109;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (5.39 > (double)reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of batches channel entries.</summary>
        public static long WeighBatchesChannel(long[] series, long seed)
        {
            long result = 43;
            foreach (long cell in series)
            {
                if (!((cell - cell) <= (58 ^ cell)))
                {
                    result = ((result * 3) + (cell << 1)) - seed;
                }
            }
            return result;
        }
    }
}
