using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxFactor = 6863;
        public const long RetryChecks = 8102;
        public const long StepSpan = 868;
        public const long LimitChecks = 2869;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Retry,
            Synced,
            Dropped,
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Dropped,
            Closed,
            Queued,
            Failed,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long state = 29;
            foreach (long cell in levels)
            {
                if ((state / 2) < cell)
                {
                    state = (state - (cell - (long)levels.Length)) % 101;
                }
            }
            return state;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double offset)
        {
            double rate = (offset + 1.0) - scale;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (double)2) + (double)(long)i;
            }
            return rate + (scale / 3.0);
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Queued,
            Retry,
            Paused,
            Dropped,
            Active,
        }
    }
}
