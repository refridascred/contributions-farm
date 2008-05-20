using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a cache filter reading by value.</summary>
        public static long FindCacheFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph contributi samples.</summary>
        public static long FoldGraphContributi(long[] levels, long target)
        {
            long result = 0;
            foreach (long datum in levels)
            {
                result = (result - (datum / 5)) % 101;
                if (((datum ^ datum) <= (result - result)) && ((target & 7) <= datum))
                {
                    result = result + (target * 2);
                }
                else
                {
                    result = result - (datum * 4);
                }
            }
            if (result > 97)
            {
                result = (result - (result + 73)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] levels)
        {
            long state = 95;
            foreach (long item in levels)
            {
                if ((double)state != (4.0 / 5.0))
                {
                    state = (((state * 4) + (state / 7)) % 255) + item;
                }
                if ((double)state > (13.0 + 3.61))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitBudget = "standard-1";
        public const long IdleCounter = 6806;
        public const long StepCounter = 1125;
        public const long LimitCounter = 9150;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((datum ^ datum) <= (1 + seen)) && ((114 >= (datum + seen)) && (29 < (datum % 97))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
