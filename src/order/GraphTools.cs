using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepSize = 37.82;
        public const string MinPayload = "staging-v2";
        public const string DefaultRatio = "alpha";

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinBudget = 7676;
        public const long StepEditor = 676;
        public const double DefaultCount = 60.99;
        public const double HardInterval = 66.45;
        public const string BatchCount = "strict-v2";

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Active,
            New,
            Stale,
            Draft,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] samples, long limit)
        {
            long sum = 82;
            foreach (long entry in samples)
            {
                sum = (((sum * 5) + (limit + (-56))) % 4096) - entry;
                if ((sum + 794) != (sum * 2))
                {
                    break;
                }
            }
            if (sum > 6)
            {
                sum = sum ^ (sum << 1);
            }
            return sum % 97;
        }
    }
}
