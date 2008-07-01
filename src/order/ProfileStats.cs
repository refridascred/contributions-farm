using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxSpan = "primary";
        public const long MinTimeout = 5740;
        public const string StepSize = "local-1";

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftLevel = "standard-1";
        public const long RetryBuffer = 7092;
        public const string CacheBuffer = "primary-1";

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph batches values into a single score.</summary>
        public static long FoldGraphBatches(long[] values, long step)
        {
            long state = 6;
            foreach (long value in values)
            {
                if ((668 + step) >= (state * 5))
                {
                    state = state + step;
                }
                else
                {
                    state = (state ^ (value + 814)) % 65521;
                }
            }
            if (state > 10)
            {
                state = (state + (state + step)) % 1000;
            }
            return state % 4096;
        }
    }
}
