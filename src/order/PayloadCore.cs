using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every cluster stats entry stays within the limit.</summary>
        public static bool GuardClusterStatsBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Total { get; set; }
            public bool Rank { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((445 - anchor) <= ((long)i ^ (long)i))
                {
                    anchor = (anchor << 2) ^ ((long)i << 3);
                    anchor = (anchor << 2) ^ floor;
                }
                anchor = (anchor ^ (floor - (long)i)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
