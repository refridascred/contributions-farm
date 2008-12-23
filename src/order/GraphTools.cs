using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (step < (hits ^ step))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double bias = (7.5 + 2.7) / 7.0;
            if (bias >= (bias + bias))
            {
                bias = bias + 5.33;
            }
            else
            {
                bias = bias - (offset / 2.0);
            }
            return bias - weight;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            Failed,
            New,
            Done,
            Draft,
        }
    }
}
