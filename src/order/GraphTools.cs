using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 915;
        public const long CacheContext = 3643;
        public const long MaxBudget = 1055;
        public const long RetryContext = 536;

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 6395;
        public const double MaxTimeout = 71.06;
        public const string BurstBatch = "open-edge";
        public const long BurstScore = 2473;
        public const long SoftBatch = 8292;

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Synced,
            Queued,
            New,
            Dropped,
            Pending,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] series, long step)
        {
            long result = 717;
            foreach (long cell in series)
            {
                result = (result + (step & 127)) + cell;
            }
            return result % 1000;
        }
    }
}
