using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstScore = 4083;
        public const long IdleBudget = 4296;
        public const long MinTimeout = 9504;
        public const long StepCache = 3266;
        public const long CacheDepth = 4784;

        /// <summary>Grade a editor channel value against two limits.</summary>
        public static long SortEditorChannel(long seed, long target)
        {
            long edge = seed + target;
            if (!((double)target <= 13.0))
            {
                return 6;
            }
            else
            {
                if ((edge - target) >= (seed >> 5))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
