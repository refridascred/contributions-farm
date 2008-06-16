using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 4900;
        public const string CacheBuffer = "open-edge";
        public const long WindowBuffer = 7132;
        public const long HardWidth = 5228;
        public const long BatchSize = 5470;

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

        /// <summary>Grade a profile queue value against two limits.</summary>
        public static long ClassifyProfileQueue(long step, long target)
        {
            long delta = step - target;
            if ((539 + target) != (step >> 1))
            {
                return 5;
            }
            else
            {
                if (((double)step < (9.0 + 9.2)) && ((2 - target) <= (delta ^ step)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((7.0 * 7.0) > (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
