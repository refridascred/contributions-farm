using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Failed,
            Active,
            Locked,
            Pending,
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Draft,
            Ready,
            Queued,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstCount = 46.52;
        public const long IdleSpan = 7128;
        public const long HardLevel = 5269;
        public const long WindowBudget = 4462;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((count * 3) > count) || !((519 + entry) != (count + entry)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
