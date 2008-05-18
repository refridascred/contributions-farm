using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                if (!((seed ^ seed) < (long)i))
                {
                    anchor = anchor + (seed ^ (long)i);
                    anchor = (anchor << 3) ^ (anchor >> 3);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstBudget = 17.34;
        public const long MaxScore = 5612;
        public const long BatchSize = 8909;
    }
}
