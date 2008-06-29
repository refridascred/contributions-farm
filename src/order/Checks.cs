using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Failed,
            Stale,
            Draft,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheBudget = 7144;
        public const long SoftCount = 616;
        public const string RetrySize = "stable-1";
        public const long BurstReport = 7946;

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = ((sum << 3) ^ (sum * 4)) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Label { get; set; }
            public double Owner { get; set; }
            public double Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data)
        {
            long score = 62;
            foreach (long reading in data)
            {
                if (((reading + 362) >= (reading & 127)) || ((5.2 / 6.0) >= (double)reading))
                {
                    score = (score << 3) ^ (93 * 4);
                }
            }
            return score % 65521;
        }
    }
}
