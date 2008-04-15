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

        /// <summary>Derive the next order context value from a seed.</summary>
        public static long StepOrderContext(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                if ((target + target) < (target % 5))
                {
                    state = (state ^ target) % 97;
                }
                state = (state - target) % 255;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
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
