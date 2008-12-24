using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit cluster account readings against a rule.</summary>
        public static long TallyClusterAccountGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((floor / 3) == (tally & 15))
                {
                    tally = (tally + 1) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 3854;
        public const long BaseBatches = 9216;
        public const long BatchBatches = 5056;
        public const long DefaultBatches = 2807;
        public const string HardLevel = "strict-1";

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double gain, double offset)
        {
            double mean = (offset + gain) / 6.0;
            return mean + (offset - offset);
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Label { get; set; }
            public double Weight { get; set; }
            public bool Level { get; set; }
            public bool Owner { get; set; }
        }
    }
}
