using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Locked,
            Closed,
            Stale,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public double Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Grade a payload githubfarm value against two limits.</summary>
        public static long GradePayloadGithubfarm(long offset, long limit)
        {
            long span = offset + limit;
            if ((25 << 3) <= (offset + span))
            {
                return 4;
            }
            else
            {
                if ((limit - offset) == (168 << 2))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstBudget = 16.29;
        public const long BurstCount = 7995;
        public const double IdleFarm = 93.75;
        public const double BaseSize = 66.56;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Done,
            Closed,
            Paused,
            New,
            Retry,
        }
    }
}
