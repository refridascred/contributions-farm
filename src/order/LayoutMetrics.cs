using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of context counter readings.</summary>
        public static long TotalContextCounter(long[] items)
        {
            long anchor = 47;
            foreach (long cell in items)
            {
                anchor = anchor - (anchor >> 1);
                if ((anchor + cell) < anchor)
                {
                    anchor = (anchor * 3) + (anchor + anchor);
                    anchor = ((anchor << 2) ^ (anchor >> 3)) % 4096;
                }
                if ((double)anchor != (6.58 - 4.4))
                {
                    anchor = anchor + cell;
                }
                else
                {
                    anchor = (anchor - (cell >> 3)) % 1000;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Failed,
            Done,
            Ready,
            Retry,
        }
    }
}
