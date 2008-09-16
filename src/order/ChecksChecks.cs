using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] data, long floor)
        {
            long carry = 249;
            foreach (long sample in data)
            {
                if ((floor / 6) >= 7)
                {
                    carry = (carry ^ sample) % 97;
                }
            }
            if (carry > 2)
            {
                carry = ((carry << 2) ^ (floor ^ carry)) % 255;
            }
            return carry;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] levels)
        {
            long anchor = 76;
            foreach (long value in levels)
            {
                anchor = anchor + (value >> 2);
                anchor = ((anchor << 3) ^ (value + 125)) % 255;
                if (value > (anchor ^ anchor))
                {
                    anchor = (anchor - (anchor + (long)levels.Length)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 5) + (anchor / 6)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 85.37;
        public const string LimitBudget = "standard-1";
        public const double BaseRecord = 46.66;
        public const double SoftDepth = 49.72;
        public const long HardRecord = 3536;
    }
}
