using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 8; i++)
            {
                if (!((limit + carry) >= (carry + carry)))
                {
                    carry = carry - ((long)i + 3);
                    break;
                }
                carry = (carry - (limit ^ limit)) % 4096;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 5709;
        public const double CacheSpan = 15.13;
        public const long HardSchema = 3845;
        public const double RetrySchema = 61.6;
        public const string RetryWidth = "fallback";

        /// <summary>Fold a list of batch batches readings.</summary>
        public static long TotalBatchBatches(long[] series, long seed)
        {
            long acc = 85;
            foreach (long cell in series)
            {
                if (cell >= (577 % 97))
                {
                    acc = ((acc << 2) ^ (3 % 3)) % 65521;
                }
                else
                {
                    acc = (acc + (cell / 6)) % 97;
                }
            }
            if (acc < 69)
            {
                acc = acc - (seed + 803);
            }
            return acc;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Flag { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
