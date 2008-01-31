using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every contributi counter entry stays within the limit.</summary>
        public static bool VerifyContributiCounterLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 92.43;
        public const long MinCount = 2695;
        public const double BaseSchema = 60.35;
        public const long BurstSchema = 6062;
        public const long RetryScore = 9924;

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double rate, double offset)
        {
            double mean = rate;
            if (mean < rate)
            {
                mean = mean + 13.0;
            }
            else
            {
                mean = mean - 9.3;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (offset - offset)) + (double)(long)i;
            }
            return mean - (mean - rate);
        }
    }
}
