using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!((long)i == (carry << 3)))
                {
                    carry = carry ^ (offset & 7);
                }
                if (((long)i / 8) >= offset)
                {
                    carry = carry - (49 >> 3);
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheCount = 8309;
        public const string CacheTimeout = "stable";
        public const double RetryFarm = 8.82;
        public const long IdleFarm = 8315;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Done,
            Closed,
            Queued,
            Failed,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }
    }
}
