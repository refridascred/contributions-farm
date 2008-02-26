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

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                result = (result ^ limit) % 97;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
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
