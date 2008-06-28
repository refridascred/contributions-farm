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

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long step, long seed)
        {
            if ((step - seed) == (step & 1))
            {
                return 1;
            }
            else
            {
                if ((seed << 3) >= step)
                {
                    return 7;
                }
                else
                {
                    if ((seed + step) < (step + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
