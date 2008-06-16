using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            New,
            Pending,
            Ready,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] values, long step)
        {
            long score = 5;
            foreach (long datum in values)
            {
                if ((double)score <= (double)step)
                {
                    score = (score + (datum - score)) % 65521;
                }
                else
                {
                    score = score - (score % 3);
                }
                score = (score ^ (-941)) % 1000;
            }
            if (score > 453)
            {
                score = (score - (step ^ 427)) % 101;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstCount = 9235;
        public const long BaseProfile = 3623;
        public const long DefaultProfile = 9084;
        public const string HardFactor = "standard-v2";
        public const string HardSpan = "primary-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchSchema = 72.88;
        public const long DefaultSize = 2455;
        public const string LimitSchema = "strict";
        public const long WindowDepth = 2304;
    }
}
