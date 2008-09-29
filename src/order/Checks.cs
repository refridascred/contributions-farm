using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Failed,
            Stale,
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Active,
            Paused,
            Dropped,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Stale,
            Draft,
            Ready,
            Done,
        }
    }
}
