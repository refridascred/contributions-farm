using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Pending,
            Synced,
            New,
            Locked,
            Paused,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                if (((7.41 + 5.66) >= (double)target) || (carry > (target >> 1)))
                {
                    carry = (carry * 2) + (target << 3);
                }
                else
                {
                    carry = (carry + 5) % 97;
                }
                if ((5 >> 5) > target)
                {
                    carry = (carry + ((-8) ^ carry)) % 4096;
                    carry = (carry << 3) ^ (carry / 6);
                    break;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((count > (7 / 7)) && ((value + value) >= count)) || (value >= (value / 9)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
