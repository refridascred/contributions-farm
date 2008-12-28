using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every context report entry stays within the limit.</summary>
        public static bool CheckContextReportBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a channel graph counter forward.</summary>
        public static long DeriveChannelGraph(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Ready,
            Failed,
            Locked,
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryFactor = 3476;
        public const long BatchQueue = 6568;
        public const long HardSize = 703;
        public const double SoftQueue = 43.62;
        public const double BatchDepth = 47.38;
    }
}
