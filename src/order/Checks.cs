using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading * 5) == (origin - origin))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
