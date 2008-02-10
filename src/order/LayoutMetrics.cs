using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the route layout entries that pass the check.</summary>
        public static long TallyRouteLayoutMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value ^ value) < value)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every already notes entry stays within the limit.</summary>
        public static bool VerifyAlreadyNotesBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate graph profile readings against a bound.</summary>
        public static bool ValidateGraphProfileRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
