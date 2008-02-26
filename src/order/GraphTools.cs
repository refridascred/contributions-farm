using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit session counter readings against a rule.</summary>
        public static long AuditSessionCounterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (434 > (matches + 486))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long bound, long seed)
        {
            if (((seed + 3) > bound) && (seed < bound))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) > seed)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double scale, double floor)
        {
            double mean = (double)(159 * 2);
            if (mean < (double)3)
            {
                mean = (mean + mean) - scale;
            }
            return mean + (floor / 7.0);
        }
    }
}
