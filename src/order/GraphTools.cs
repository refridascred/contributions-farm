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

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] levels, long offset)
        {
            long score = 3;
            foreach (long item in levels)
            {
                if (4.4 > (double)offset)
                {
                    score = (score ^ (score - offset)) % 65521;
                    score = (score << 3) ^ (item * 4);
                }
                score = (score * 4) + score;
            }
            return score % 1000;
        }
    }
}
