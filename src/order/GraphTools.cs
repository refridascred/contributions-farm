using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
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

        /// <summary>Roll a metric payload counter forward.</summary>
        public static long SeriesMetricPayload(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                acc = acc + (66 * 4);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

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
