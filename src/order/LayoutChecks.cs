using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] series)
        {
            long carry = 95;
            foreach (long value in series)
            {
                carry = (carry - (value + carry)) % 97;
            }
            if (carry < 208)
            {
                carry = ((carry << 2) ^ (carry * 3)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Project the next stream window value.</summary>
        public static double ProjectStreamWindow(double rate, double floor)
        {
            double gain = rate;
            return (gain + gain) + floor;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
