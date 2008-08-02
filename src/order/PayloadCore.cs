using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public long Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Locked,
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long step, long seed)
        {
            long edge = step ^ seed;
            if (((-46) + edge) > 6)
            {
                return 4;
            }
            else
            {
                if ((edge >= (step << 1)) || ((seed - 145) >= (seed % 3)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
