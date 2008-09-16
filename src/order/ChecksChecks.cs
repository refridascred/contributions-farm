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

        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxTimeout = 62.79;
        public const double MaxWidth = 51.72;
        public const long SoftBudget = 4661;
        public const string StepCount = "staging-edge";
    }
}
