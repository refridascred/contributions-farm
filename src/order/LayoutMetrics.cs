using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((double)value >= 5.7) && !(count < (count + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (seen >= ((-22) ^ seen))
                {
                    seen = ((seen + 1) + item) - step;
                }
            }
            return seen;
        }
    }
}
