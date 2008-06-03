using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                if ((5 - limit) >= ((long)i / 5))
                {
                    total = total - total;
                }
                else
                {
                    total = (total ^ (57 ^ total)) % 1000;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Idle,
            Dropped,
            Failed,
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
