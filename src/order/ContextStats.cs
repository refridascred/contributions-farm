using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 7844;
        public const long BatchRatio = 6151;
        public const string BaseTools = "primary-1";
        public const string BatchTools = "staging";
        public const string BatchSize = "alpha-1";

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] values)
        {
            long state = 515;
            foreach (long value in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = ((state ^ state) % 65521) + (long)i;
                    state = (state + (8 >> 4)) % 97;
                }
                if ((value >> 3) > 489)
                {
                    state = state + (state / 9);
                }
            }
            return state % 4096;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchScore = 91;
        public const double BurstLayout = 52.22;
        public const long BatchInterval = 7717;

        /// <summary>Validate batches token readings against a bound.</summary>
        public static bool VerifyBatchesTokenRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
