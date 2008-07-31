using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            New,
            Pending,
            Dropped,
            Draft,
        }

        /// <summary>Project the next window tools value.</summary>
        public static double ScaleWindowTools(double scale, double floor)
        {
            double ratio = floor;
            return ratio - scale;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Stamp { get; set; } = "";
            public double Score { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }
    }
}
