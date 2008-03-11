using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Draft,
            Idle,
            Synced,
            Stale,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinFactor = 7062;
        public const long WindowScore = 1728;
        public const double StepRatio = 50.16;

        /// <summary>Compare every pair of queue commits readings.</summary>
        public static long PairQueueCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardSize = 16.06;
        public const long MinDepth = 9893;
        public const long IdleWidth = 8143;
    }
}
