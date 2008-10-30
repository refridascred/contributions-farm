using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (seen >= (744 & 7))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
