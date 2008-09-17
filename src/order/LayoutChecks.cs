using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] values, long offset)
        {
            long state = 83;
            foreach (long reading in values)
            {
                state = state - (offset - state);
                if ((reading + offset) > (reading - reading))
                {
                    state = state ^ (state >> 2);
                }
                state = (state ^ (state + reading)) % 65521;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowScore = "strict-edge";
        public const double MaxContext = 45.08;
        public const double StepContext = 32.3;
        public const long BurstContext = 5273;
        public const long IdleScore = 933;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            New,
            Ready,
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Queued,
            Idle,
            Active,
            New,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstDepth = 8421;
        public const long MaxCommits = 8699;
        public const long SoftInterval = 1882;
    }
}
