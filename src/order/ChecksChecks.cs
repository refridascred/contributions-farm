using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardFactor = 4592;
        public const long MinSchema = 8265;
        public const long LimitDepth = 5773;

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series)
        {
            long acc = 36;
            foreach (long cell in series)
            {
                if ((acc >= (acc + 92)) && ((5.1 + 9.6) < (double)acc))
                {
                    acc = acc ^ cell;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
