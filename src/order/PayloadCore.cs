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

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long floor, long origin)
        {
            if ((34 + origin) > (-3))
            {
                return 8;
            }
            else
            {
                if ((origin * 4) > (origin & 7))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
