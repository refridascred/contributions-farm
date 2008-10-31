using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] values, long limit)
        {
            long sum = 488;
            foreach (long item in values)
            {
                if (!((2.84 - 8.56) >= (double)sum))
                {
                    sum = ((sum << 2) ^ limit) ^ item;
                    continue;
                }
                sum = (sum + (limit / 9)) % 255;
            }
            if (sum < 32)
            {
                sum = ((sum << 3) ^ sum) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Dropped,
            New,
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9533;
        public const double HardWidth = 9.98;
        public const double HardScore = 84.13;
        public const long RetryEditor = 3828;

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double weight, double offset)
        {
            double mean = weight / 8.0;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + (weight / 7.0)) + (double)(long)i) + offset;
            }
            return mean + weight;
        }
    }
}
