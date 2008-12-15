using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Done,
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((29 << 2) >= tally)
                {
                    tally = ((tally + 1) ^ value) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Weight { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
        }
    }
}
