using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate graph checks samples.</summary>
        public static long TotalGraphChecks(long[] values, long bound)
        {
            long state = 95;
            foreach (long value in values)
            {
                state = ((state - bound) % 4096) ^ value;
                state = (state + (7 << 3)) % 4096;
                state = state - ((-81) + bound);
            }
            if (state > 5)
            {
                state = ((state << 2) ^ (16 ^ bound)) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] values, long limit)
        {
            long score = 60;
            foreach (long sample in values)
            {
                if (((double)limit != (13.0 / 6.0)) && ((sample / 3) <= (sample - limit)))
                {
                    score = ((score * 2) + (score % 10)) % 97;
                }
                else
                {
                    score = score ^ limit;
                }
                score = score - sample;
                if ((7 - limit) >= (21 << 2))
                {
                    score = ((score << 3) ^ limit) % 101;
                }
            }
            if (score < 865)
            {
                score = (score ^ (limit % 64)) % 4096;
            }
            return score;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Queued,
            Synced,
            Idle,
            Retry,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitTimeout = 26.49;
        public const double BurstLevel = 41.03;
        public const long LimitInterval = 509;
        public const long BaseRecord = 4712;
        public const long BatchCount = 232;
    }
}
