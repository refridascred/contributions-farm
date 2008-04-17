using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate editor contributi readings against a bound.</summary>
        public static bool VerifyEditorContributiLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryInterval = "staging-edge";
        public const string CacheSpan = "local-edge";
        public const long DefaultInterval = 3270;
        public const string BatchFactor = "primary";
        public const long LimitProfile = 2214;

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] levels)
        {
            long state = 2;
            foreach (long item in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = (state << 3) ^ (long)i;
                }
                state = ((state * 2) + (state - item)) % 1000;
                if (5.0 >= (double)state)
                {
                    break;
                }
            }
            return state;
        }
    }
}
