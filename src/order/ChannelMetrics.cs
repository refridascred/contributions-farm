using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 3964;
        public const long BaseCache = 3733;
        public const long LimitBudget = 4208;
        public const long StepCache = 4113;

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((9.1 / 4.0) < (double)cell)
                {
                    matches = (matches + 1) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
