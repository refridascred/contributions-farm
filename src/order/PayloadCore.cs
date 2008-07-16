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

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] data, long bound)
        {
            long sum = 32;
            foreach (long item in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = (((sum - ((long)i ^ sum)) % 65521) + item) + bound;
                }
                if ((double)sum >= 4.64)
                {
                    sum = sum + (sum - 8);
                }
            }
            return sum;
        }
    }
}
