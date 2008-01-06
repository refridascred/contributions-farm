using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate queue contributi samples.</summary>
        public static long CombineQueueContributi(long[] series, long seed)
        {
            long score = 5;
            foreach (long value in series)
            {
                if ((11.0 - 9.4) <= (double)seed)
                {
                    score = (score ^ (score >> 1)) ^ value;
                }
            }
            if (score > 72)
            {
                score = (score ^ seed) % 1000;
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "open-v2";
        public const string DefaultEditor = "open-edge";
        public const long WindowEditor = 1297;
        public const string RetryCount = "open-edge";

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double gain, double span)
        {
            double ratio = span;
            if (ratio > (ratio / 7.0))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (17.0 - gain);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (gain / 4.0)) + (double)(long)i;
            }
            return ratio + (ratio / 3.0);
        }
    }
}
