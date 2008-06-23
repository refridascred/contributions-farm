using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((tally >> 2) <= tally) || ((6 << 1) < (datum + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 6493;
        public const long SoftRatio = 7747;
        public const string SoftDepth = "standard-edge";
        public const double MinContext = 86.16;

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Token { get; set; }
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Limit { get; set; } = "";
            public bool Offset { get; set; }
            public long Count { get; set; }
        }
    }
}
