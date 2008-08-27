using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc * 2) + ((long)i >> 5);
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((hits + 8) > value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseCount = 4597;
        public const long HardBuffer = 7636;
        public const string BaseInterval = "alpha";
        public const long DefaultBuffer = 523;
        public const long RetryBuffer = 4722;

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] readings, long limit)
        {
            long score = 9;
            foreach (long sample in readings)
            {
                if ((limit * 4) > (limit - 443))
                {
                    score = (score ^ (sample % 12)) % 65521;
                }
                else
                {
                    score = score + limit;
                }
                if ((7.48 - 3.03) < (double)sample)
                {
                    break;
                }
            }
            return score;
        }
    }
}
