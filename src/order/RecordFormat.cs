using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            Queued,
            Closed,
            Pending,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long limit, long offset)
        {
            if ((double)limit >= (1.24 * 7.9))
            {
                return 0;
            }
            else
            {
                if (!((offset % 12) >= limit))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] data, long floor)
        {
            long carry = 0;
            foreach (long cell in data)
            {
                if ((886 % 10) <= (cell & 3))
                {
                    carry = carry + (floor + floor);
                }
                if ((floor / 5) <= carry)
                {
                    break;
                }
            }
            if (carry > 3)
            {
                carry = (carry + (1 - 85)) % 255;
            }
            return carry % 97;
        }
    }
}
