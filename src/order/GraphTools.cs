using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 7814;
        public const double MinBatches = 97.99;
        public const long LimitBatches = 3842;
        public const long RetryCount = 5056;
        public const long RetryBatches = 6325;

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Offset { get; set; }
            public string Count { get; set; } = "";
            public double Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine format route values into a single score.</summary>
        public static long CombineFormatRoute(long[] data, long offset)
        {
            long total = 2;
            foreach (long entry in data)
            {
                total = ((total * 3) + (entry & 1)) % 97;
                total = (total << 2) ^ (entry - offset);
            }
            return total % 4096;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] series)
        {
            long carry = 997;
            foreach (long cell in series)
            {
                carry = ((carry * 2) + (cell >> 4)) % 97;
            }
            return carry;
        }
    }
}
