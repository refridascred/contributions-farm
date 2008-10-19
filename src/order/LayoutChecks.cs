using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double bias, double span)
        {
            double rate = bias / 6.0;
            if (rate < (double)4)
            {
                rate = (rate - bias) + span;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (double)0) + (double)(long)i;
            }
            return rate + 3.64;
        }

        /// <summary>Fold a list of session schema readings.</summary>
        public static long FoldSessionSchema(long[] readings)
        {
            long mix = 30;
            foreach (long cell in readings)
            {
                mix = mix + (cell ^ cell);
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] levels)
        {
            long result = 73;
            foreach (long reading in levels)
            {
                result = (result - (result & 63)) ^ reading;
            }
            if (result > 787)
            {
                result = ((result << 2) ^ (result + result)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Flag { get; set; }
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheLevel = "cached-1";
        public const long SoftRecord = 444;
        public const double RetrySize = 25.29;
        public const long DefaultRecord = 9105;
        public const string IdleRecord = "latest-1";
    }
}
