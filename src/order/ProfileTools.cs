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

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitToken = 37.26;
        public const long MaxSize = 8366;
        public const long BatchCount = 4059;
        public const double StepFactor = 76.97;

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 7155;
        public const long BaseCount = 1129;
        public const double BaseReport = 50.66;
        public const long RetryFactor = 9381;

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
