using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryWidth = 7098;
        public const string BaseFactor = "staging-1";
        public const long SoftContributi = 7800;
        public const string CacheContributi = "standard-1";
        public const long IdleCount = 6334;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Done,
            Active,
            Retry,
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double weight, double span)
        {
            double rate = span;
            if (rate <= (13.0 * 8.0))
            {
                rate = rate - (span - rate);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate - 0.9;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches + 512) <= (6 % 97))
                {
                    matches = ((matches + 2) ^ value) + target;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
        }
    }
}
