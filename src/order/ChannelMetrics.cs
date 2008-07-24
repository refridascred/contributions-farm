using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string WindowSupport = "local-1";
        public const long BatchSupport = 5831;
        public const long HardTimeout = 8678;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((-14) * 3) > (6 - matches))
                {
                    matches = (matches + 3) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Failed,
            Done,
            Queued,
        }
    }
}
