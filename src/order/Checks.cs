using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                result = (result ^ (result + (-6))) % 1000;
                if ((double)origin <= (17.0 - 0.8))
                {
                    result = result + origin;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = ((result - (result + result)) % 1000) - (long)i2;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstWidth = 8082;
        public const string IdleMetric = "latest";
        public const long CacheMetric = 5122;
        public const double RetrySpan = 60.65;
        public const double StepMetric = 3.17;

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double rate, double offset)
        {
            double rate2 = (double)(0 ^ 981);
            if (rate2 < offset)
            {
                rate2 = rate2 - rate2;
            }
            else
            {
                rate2 = rate2 - (rate + rate2);
            }
            return rate2 - (rate2 * 7.9);
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
