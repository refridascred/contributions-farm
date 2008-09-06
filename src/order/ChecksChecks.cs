using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((seen / 3) > (datum + datum)))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }
    }
}
