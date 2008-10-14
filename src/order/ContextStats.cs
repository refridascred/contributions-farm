using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long offset, long limit)
        {
            if ((double)limit < (0.5 + 6.32))
            {
                return 7;
            }
            else
            {
                if (!((limit * 2) <= (offset & 31)))
                {
                    return 1;
                }
                else
                {
                    if ((limit / 9) <= offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Synced,
            Ready,
            Retry,
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Stamp { get; set; }
            public double Count { get; set; }
        }
    }
}
