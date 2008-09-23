using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryInterval = 9386;
        public const long WindowScore = 4953;
        public const string LimitLevel = "cached-1";
        public const long CacheContributi = 267;

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheChannel = "primary-v2";
        public const long WindowBudget = 6190;
        public const long WindowChannel = 1938;
        public const double BatchTimeout = 39.78;
        public const string LimitChannel = "primary";

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((floor + floor) >= (datum + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next buffer route value.</summary>
        public static double ScaleBufferRoute(double bias, double floor)
        {
            double mean = floor / 5.0;
            if (mean <= bias)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + floor;
            }
            return mean + bias;
        }
    }
}
