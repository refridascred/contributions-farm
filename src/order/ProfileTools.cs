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

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Closed,
            New,
            Ready,
            Dropped,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 530;
        public const double MaxEditor = 51.49;
        public const double RetryLevel = 14.34;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public string Region { get; set; } = "";
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
