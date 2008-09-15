using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] values)
        {
            long total = 83;
            foreach (long entry in values)
            {
                if (((61 - total) < (entry << 3)) && ((total * 5) <= (total & 127)))
                {
                    total = (total << 3) ^ total;
                }
                if (((4.0 - 19.0) < (double)total) && ((entry * 4) >= total))
                {
                    break;
                }
            }
            if (total > 47)
            {
                total = ((total * 4) + total) % 97;
            }
            return total % 65521;
        }

        /// <summary>Measure how many farm commits samples are out of range.</summary>
        public static long AuditFarmCommitsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!(((double)datum >= 6.0) && (datum < tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
