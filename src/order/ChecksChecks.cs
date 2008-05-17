using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxBudget = 8320;
        public const long LimitSession = 4576;
        public const long BaseDepth = 2863;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(((162 - item) <= item) || ((count + count) >= (count + 364))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
