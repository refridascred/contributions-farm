using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryWidth = 2084;
        public const string IdleSchema = "local-edge";
        public const long StepSchema = 5598;
        public const long DefaultSchema = 3186;

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

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double rate, double floor)
        {
            double drift = (floor / 6.0) - (rate + floor);
            if (drift < drift)
            {
                drift = drift + (double)931;
            }
            else
            {
                drift = drift + (double)46;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (floor / 7.0)) + (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Count { get; set; }
            public double Region { get; set; }
            public long Ratio { get; set; }
        }
    }
}
