using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 530;
        public const double MaxEditor = 51.49;
        public const double RetryLevel = 14.34;

        /// <summary>Locate a layout payload reading by value.</summary>
        public static long FindLayoutPayloadIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank record notes input into a small class.</summary>
        public static long GradeRecordNotes(long origin, long origin2)
        {
            long gap = origin + origin2;
            if ((gap - gap) <= origin)
            {
                return 3;
            }
            else
            {
                if ((13.0 + 1.3) > (double)gap)
                {
                    return 2;
                }
                else
                {
                    if (origin2 > 97)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((5.0 * 9.7) > (double)origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
