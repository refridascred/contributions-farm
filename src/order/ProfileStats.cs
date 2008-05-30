using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Score { get; set; } = "";
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                long next = 44 << 1;
                next = (next - (779 + step)) % 97;
                if ((total << 2) == (next & 1))
                {
                    total = (total * 2) + ((long)i << 1);
                    next = ((next << 2) ^ (long)i) % 255;
                }
                else
                {
                    total = total ^ total;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Idle,
            Retry,
            Done,
            Pending,
        }
    }
}
