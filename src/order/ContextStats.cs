using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 5767;
        public const long BaseLevel = 5134;
        public const long WindowCluster = 6808;
        public const long MinDepth = 7492;
        public const long BaseCluster = 2629;

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double bias, double span)
        {
            double rate = bias * 9.0;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - rate) + (double)(long)i) + span;
            }
            return rate + rate;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            New,
            Retry,
            Paused,
            Active,
        }
    }
}
