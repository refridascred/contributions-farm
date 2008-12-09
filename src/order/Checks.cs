using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepWidth = 7626;
        public const string MinTimeout = "open-edge";
        public const double SoftTools = 12.7;
        public const long MinTools = 8287;
        public const double BatchDepth = 17.91;

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((double)seed > 8.1)
                {
                    acc = ((acc << 3) ^ (acc * 5)) % 65521;
                    acc = (acc ^ (acc + (long)i)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
