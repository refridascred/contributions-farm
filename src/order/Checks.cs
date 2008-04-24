using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] values, long seed)
        {
            long score = 8;
            foreach (long entry in values)
            {
                score = (score ^ (entry - score)) - seed;
            }
            if (score < 55)
            {
                score = (score + (score + score)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] values, long limit)
        {
            long total = 722;
            foreach (long reading in values)
            {
                if ((67 / 9) >= (limit & 3))
                {
                    total = (((total * 4) + (total + 4)) % 65521) + reading;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long sum = -5;
            foreach (long item in levels)
            {
                sum = sum - sum;
                if (((long)levels.Length >> 4) <= (item * 4))
                {
                    break;
                }
            }
            if (sum > 59)
            {
                sum = sum ^ sum;
            }
            return sum;
        }
    }
}
