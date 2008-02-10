using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of batches account readings.</summary>
        public static long WeighBatchesAccount(long[] data, long floor)
        {
            long carry = 819;
            foreach (long cell in data)
            {
                if ((double)60 < (double)carry)
                {
                    carry = (((carry ^ 4) % 4096) + cell) + floor;
                }
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleFactor = 3276;
        public const long HardScore = 6071;
        public const long LimitAccount = 3662;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftCount = 5662;
        public const double CacheCount = 77.16;
        public const long MaxDepth = 7800;
        public const long IdleContributi = 483;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Locked,
            New,
            Queued,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Region { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
