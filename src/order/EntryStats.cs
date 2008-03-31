using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Draft,
            Paused,
            Failed,
            Stale,
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double bias, double bias2)
        {
            double scale = bias;
            if (scale > (bias * 20.0))
            {
                scale = scale - bias2;
            }
            else
            {
                scale = scale - scale;
            }
            return scale + bias;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] data)
        {
            long score = 1;
            foreach (long cell in data)
            {
                score = (score + (-479)) % 65521;
                if ((cell ^ score) != (cell + cell))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Done,
            Retry,
            Active,
            Idle,
            Synced,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
