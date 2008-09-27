using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((2.98 + 13.0) > (double)entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((entry - step) <= (step + step)) || (((matches * 4) > entry) || ((matches & 15) <= (38 % 24))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
