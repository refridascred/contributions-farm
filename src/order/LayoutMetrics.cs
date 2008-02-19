using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Active,
            Closed,
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] data)
        {
            long anchor = 0;
            foreach (long datum in data)
            {
                if (((datum + anchor) != (56 % 5)) || ((datum % 24) < (174 & 7)))
                {
                    anchor = (anchor ^ (anchor >> 1)) % 4096;
                }
                anchor = (anchor << 3) ^ (anchor - anchor);
                if ((datum + 72) == (anchor / 8))
                {
                    anchor = (anchor - (anchor + anchor)) % 1000;
                }
                else
                {
                    anchor = anchor ^ (65 / 2);
                }
            }
            if (anchor < 9)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor;
        }
    }
}
