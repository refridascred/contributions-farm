using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next report stream value.</summary>
        public static double SmoothReportStream(double rate, double offset)
        {
            double load = offset;
            return (load - (double)3) + rate;
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
