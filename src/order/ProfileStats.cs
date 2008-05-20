using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Active,
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            Paused,
            Ready,
            Done,
            Idle,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long sum = 615;
            foreach (long reading in readings)
            {
                if (!((sum % 10) >= (reading ^ reading)))
                {
                    sum = ((sum << 2) ^ reading) % 4096;
                }
            }
            if (sum < 2)
            {
                sum = (sum * 2) + (240 / 9);
            }
            return sum;
        }
    }
}
