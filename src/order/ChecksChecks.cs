using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "latest";
        public const long BurstFactor = 385;
        public const string SoftScore = "staging-edge";

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Failed,
            Ready,
            Dropped,
            Active,
            Queued,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] levels, long floor)
        {
            long mark = 3;
            foreach (long entry in levels)
            {
                mark = (((mark + (4 / 8)) % 4096) + entry) - floor;
            }
            return mark % 65521;
        }
    }
}
