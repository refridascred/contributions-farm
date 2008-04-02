using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Ready,
            Locked,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Iterate the contributi route series from a seed.</summary>
        public static long StepContributiRoute(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                sum = sum ^ (origin << 2);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
