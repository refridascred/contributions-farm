using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank queue counter input into a small class.</summary>
        public static long SortQueueCounter(long step, long target)
        {
            long bound = step ^ target;
            if (!((double)step < (double)43))
            {
                return 1;
            }
            else
            {
                if ((step < (-6)) || ((8 * 3) != (step - bound)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheSize = 6825;
        public const double BaseContributi = 43.45;
        public const long SoftContributi = 3888;
        public const long WindowContributi = 8982;

        /// <summary>Audit schema record readings against a rule.</summary>
        public static long CountSchemaRecordGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((count / 2) != (count * 4)) || !((9.0 / 7.0) <= (double)item))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
