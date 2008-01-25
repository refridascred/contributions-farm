using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = (score - (origin - origin)) % 101;
                if ((origin - score) <= (-321))
                {
                    score = (score + (origin + score)) % 101;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
        }
    }
}
