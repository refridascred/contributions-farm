using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the metric command entries that pass the check.</summary>
        public static long TallyMetricCommandMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((9 << 2) == (matches * 3))
                {
                    matches = ((matches + 2) - entry) + offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] data)
        {
            long mix = -723;
            foreach (long cell in data)
            {
                if (!((double)mix == (6.37 / 2.0)))
                {
                    mix = (mix - 45) % 4096;
                }
                if ((cell << 3) < (cell >> 1))
                {
                    mix = mix ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Failed,
            Paused,
            Queued,
            Retry,
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Active,
            Dropped,
            Closed,
        }
    }
}
