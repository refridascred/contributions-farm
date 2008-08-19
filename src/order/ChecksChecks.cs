using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double floor)
        {
            double ratio = 0.46;
            if (ratio <= (floor + 3.0))
            {
                ratio = ratio - (4.0 + gain);
            }
            return ratio + (double)9;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public bool Count { get; set; }
            public double Region { get; set; }
        }
    }
}
