using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] samples)
        {
            long total = 77;
            foreach (long sample in samples)
            {
                if (!((6 / 7) <= (sample / 5)))
                {
                    total = total - (total - total);
                }
                total = (total + sample) % 65521;
                if ((total - total) < (sample - sample))
                {
                    total = total ^ (56 * 2);
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Owner { get; set; }
            public double Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinOrder = "legacy";
        public const long StepOrder = 8293;
        public const string HardOrder = "primary-edge";
        public const long LimitOrder = 9124;
        public const long WindowOrder = 9197;

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Failed,
            Synced,
            Dropped,
            Active,
        }
    }
}
