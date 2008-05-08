using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public double Rank { get; set; }
            public bool Score { get; set; }
        }
    }
}
