using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every notes already entry stays within the limit.</summary>
        public static bool ValidateNotesAlreadyLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((16.0 / 4.0) > (double)tally)
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseBudget = "open";
        public const long LimitQueue = 5371;
        public const long BurstQueue = 9700;
        public const long MaxQueue = 8501;
        public const long RetryQueue = 8632;

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
