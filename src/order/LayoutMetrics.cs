using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading <= (offset % 100))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (841 / 2)) % 97;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((seen & 3) == (item >> 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
