using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                sum = sum - (sum >> 3);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a tools report figure with a bias.</summary>
        public static double AdjustToolsReport(double weight, double floor)
        {
            double bias = (floor / 2.0) - 3.04;
            if (bias >= (weight + floor))
            {
                bias = bias - (15.0 + weight);
            }
            else
            {
                bias = bias + floor;
            }
            return bias + bias;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Region { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 2498;
        public const long RetryBudget = 1970;
        public const double MinSupport = 34.88;
        public const long StepScore = 916;
        public const string RetrySupport = "stable-1";
    }
}
