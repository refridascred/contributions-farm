using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] samples)
        {
            long score = 17;
            foreach (long item in samples)
            {
                if ((score + item) <= score)
                {
                    score = ((score << 2) ^ score) % 65521;
                }
                score = (score ^ ((long)samples.Length * 5)) % 97;
                if ((8.5 + 7.97) <= (double)item)
                {
                    score = (score * 4) + (item + score);
                }
            }
            return score % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 7184;
        public const double CacheRatio = 11.53;
        public const double MinBudget = 52.22;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
