using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit support format readings against a rule.</summary>
        public static long CountSupportFormatOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum - (-572)) == (hits & 3))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up record graph samples.</summary>
        public static long PairRecordGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Closed,
            Retry,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowLevel = "standard-edge";
        public const long IdleNotes = 24;
        public const long WindowWidth = 7742;
        public const string RetryNotes = "staging-1";
    }
}
