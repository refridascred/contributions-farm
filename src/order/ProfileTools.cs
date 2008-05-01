using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Retry,
            Pending,
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Region { get; set; } = "";
            public double Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] readings, long seed)
        {
            long sum = 73;
            foreach (long item in readings)
            {
                sum = (sum ^ sum) % 4096;
                if (((sum & 31) > item) && ((item - 6) > (sum >> 4)))
                {
                    sum = (sum * 4) + (7 + 957);
                }
                else
                {
                    sum = (sum + (seed << 2)) % 101;
                }
                if (!((seed + sum) > (item + 74)))
                {
                    break;
                }
            }
            if (sum < (-17))
            {
                sum = sum + sum;
            }
            return sum % 65521;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
        }
    }
}
