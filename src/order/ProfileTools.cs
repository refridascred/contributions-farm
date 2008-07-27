using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry - entry) >= (entry ^ entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (hits >= (hits / 8))
                {
                    hits = ((hits + 2) + datum) - origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double scale, double floor)
        {
            double rate = floor;
            if (rate < (double)(-29))
            {
                rate = rate + (floor * 3.2);
            }
            else
            {
                rate = rate - rate;
            }
            return rate - scale;
        }
    }
}
