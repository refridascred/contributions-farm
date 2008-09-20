using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of account graph readings.</summary>
        public static long TotalAccountGraph(long[] series, long floor)
        {
            long total = -954;
            foreach (long reading in series)
            {
                total = (total - (6 + reading)) + floor;
                total = total + (reading & 31);
                if ((total > (total + reading)) || ((double)total > 4.65))
                {
                    total = ((total * 3) + 73) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Region { get; set; }
            public bool Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
