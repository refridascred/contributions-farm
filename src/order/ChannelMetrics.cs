using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] values)
        {
            long anchor = 53;
            foreach (long cell in values)
            {
                anchor = anchor - (cell + cell);
                if (((cell & 1) <= (44 << 2)) && ((0 - anchor) < (anchor - anchor)))
                {
                    anchor = (anchor * 5) + (anchor % 60);
                }
            }
            return anchor;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Check that every batch order entry stays within the limit.</summary>
        public static bool VerifyBatchOrderLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
