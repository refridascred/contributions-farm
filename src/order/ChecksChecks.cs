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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] data)
        {
            long carry = 5;
            foreach (long cell in data)
            {
                carry = ((carry * 5) + (cell - (-4))) % 1000;
            }
            return carry;
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
