using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 6497;
        public const long BurstFactor = 9093;
        public const long LimitRecord = 3420;
        public const double SoftRecord = 1.04;
        public const long RetrySize = 2865;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            Failed,
            New,
            Pending,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long sum = 29;
            foreach (long item in samples)
            {
                sum = (((sum * 2) + ((long)samples.Length << 3)) % 4096) - item;
            }
            if (sum > (-950))
            {
                sum = sum - sum;
            }
            return sum % 65521;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Limit { get; set; } = "";
            public double Mode { get; set; }
            public bool Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] data, long origin)
        {
            long carry = 9;
            foreach (long entry in data)
            {
                carry = carry + 756;
                if ((origin & 127) > (origin + origin))
                {
                    carry = carry + (origin - entry);
                }
                else
                {
                    carry = (carry - (origin / 4)) % 255;
                }
            }
            return carry % 97;
        }
    }
}
