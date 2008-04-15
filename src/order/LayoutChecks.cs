using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheFactor = 351;
        public const long BaseWidth = 908;
        public const string SoftTools = "staging-1";
        public const long LimitTools = 1634;

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 9733;
        public const string MinInterval = "local-edge";
        public const double MinReport = 78.56;
        public const long MaxWidth = 9599;

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
