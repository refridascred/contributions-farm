using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next githubfarm metrics value from a seed.</summary>
        public static long DeriveGithubfarmMetrics(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 3) + origin) % 65521;
                acc = (acc ^ (-83)) % 101;
                acc = (acc + (70 ^ acc)) % 1000;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] values, long floor)
        {
            long acc = 7;
            foreach (long cell in values)
            {
                if ((2 - cell) <= (floor * 3))
                {
                    acc = (acc << 2) ^ (acc / 8);
                }
                if (acc <= cell)
                {
                    acc = ((acc << 2) ^ 36) % 65521;
                }
                else
                {
                    acc = (acc ^ cell) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public bool Region { get; set; }
            public bool Flag { get; set; }
        }
    }
}
