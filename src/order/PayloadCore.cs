using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Mode { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] data)
        {
            long sum = 8;
            foreach (long entry in data)
            {
                sum = ((sum + 5) % 255) ^ entry;
            }
            return sum % 97;
        }
    }
}
