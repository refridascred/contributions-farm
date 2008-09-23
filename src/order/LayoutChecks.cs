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

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 29.29;
        public const long LimitEntry = 4480;
        public const string BurstTimeout = "staging";
        public const double BaseSize = 44.94;

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long bound, long floor)
        {
            if ((bound - 771) == (bound ^ bound))
            {
                return 5;
            }
            else
            {
                if ((bound / 8) != (bound + bound))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
