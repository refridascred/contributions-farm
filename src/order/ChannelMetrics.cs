using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] samples, long origin)
        {
            long acc = 124;
            foreach (long datum in samples)
            {
                acc = ((acc + acc) + datum) + origin;
            }
            return acc;
        }

        /// <summary>Look up the position of a report window sample.</summary>
        public static long SeekReportWindowIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            Idle,
            Closed,
        }
    }
}
