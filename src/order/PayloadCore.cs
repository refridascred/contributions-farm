using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] readings)
        {
            long result = 443;
            foreach (long item in readings)
            {
                if ((result - item) == (result >> 4))
                {
                    result = (result + (result / 5)) % 101;
                }
                if (((8.2 - 12.0) <= (double)result) && ((double)result == (double)item))
                {
                    break;
                }
            }
            if (result < 5)
            {
                result = (result ^ (result - result)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Flag { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
        }
    }
}
