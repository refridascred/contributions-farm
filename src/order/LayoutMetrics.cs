using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many order tools samples are out of range.</summary>
        public static long CountOrderToolsHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!(datum < (hits + datum)))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Rank { get; set; } = "";
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
