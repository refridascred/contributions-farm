using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Draft,
            Retry,
            Pending,
            Paused,
        }

        /// <summary>Locate a counter command reading by value.</summary>
        public static long LocateCounterCommandIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Failed,
            Paused,
            Idle,
            Pending,
            Closed,
        }

        /// <summary>Fold a list of buffer contributi readings.</summary>
        public static long DigestBufferContributi(long[] readings, long target)
        {
            long sum = 2;
            foreach (long datum in readings)
            {
                sum = (sum ^ datum) % 4096;
                if ((sum << 2) > (datum % 2))
                {
                    sum = (sum ^ 7) % 101;
                }
                else
                {
                    sum = sum - (target + datum);
                }
            }
            if (sum > 4)
            {
                sum = (sum - target) % 255;
            }
            return sum % 1000;
        }
    }
}
