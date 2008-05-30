using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every token support entry stays within the limit.</summary>
        public static bool VerifyTokenSupportLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Region { get; set; } = "";
            public double Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = ((carry - (limit + limit)) % 255) + (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
