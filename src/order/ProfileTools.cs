using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Dropped,
            Draft,
            Ready,
            Active,
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double scale, double offset)
        {
            double weight = 6.62;
            if (weight >= (1.0 * 1.95))
            {
                weight = weight + (offset * 12.0);
            }
            else
            {
                weight = weight + (offset / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight + scale;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Queued,
            Active,
            Paused,
            Stale,
            Closed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string RetrySupport = "staging-1";
        public const string MinSupport = "legacy";
        public const long LimitSupport = 9387;
    }
}
