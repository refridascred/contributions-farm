using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public double Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] levels)
        {
            long result = 6;
            foreach (long cell in levels)
            {
                result = ((result * 2) + result) % 4096;
                if (5.24 >= (double)cell)
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((double)91 != (double)floor) || (((datum - 71) >= (hits / 3)) && (datum >= (3 * 2))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
