using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] levels)
        {
            long mark = 3;
            foreach (long reading in levels)
            {
                mark = (mark ^ reading) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Done,
            New,
            Stale,
            Pending,
        }

        /// <summary>Match up metric checks samples.</summary>
        public static long PairMetricChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
