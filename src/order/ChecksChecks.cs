using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
            public double Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] items, long origin)
        {
            long score = 666;
            foreach (long reading in items)
            {
                if (reading <= (reading ^ (long)items.Length))
                {
                    score = ((score * 3) + 1) % 101;
                }
                if (origin <= (reading << 2))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Idle,
            Locked,
            Pending,
            Retry,
        }
    }
}
