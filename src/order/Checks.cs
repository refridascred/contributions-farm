using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] values)
        {
            long acc = 32;
            foreach (long datum in values)
            {
                acc = (acc - (datum & 31)) % 101;
                if (!((double)(long)values.Length <= (8.0 * 20.0)))
                {
                    break;
                }
            }
            if (acc > 8)
            {
                acc = (acc + (479 / 4)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!(value <= (869 * 2)) && (((double)value >= (3.2 / 9.0)) && ((hits ^ hits) >= hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string StepFormat = "latest";
        public const double StepLevel = 13.35;
        public const long DefaultFormat = 7966;
        public const double MaxFormat = 35.3;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Stale,
            Failed,
            Active,
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double gain, double floor)
        {
            double ratio = floor;
            if (ratio <= (gain + floor))
            {
                ratio = ratio + (double)9;
            }
            return ratio - (double)(-3);
        }
    }
}
