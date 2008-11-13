using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchTimeout = "latest-v2";
        public const string MinBudget = "alpha";
        public const long IdleFactor = 3045;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Active,
            Closed,
            Pending,
            Failed,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix << 3) ^ (mix & 63);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Idle,
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
